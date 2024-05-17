// llamadas directas a la API del servidor

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
//NuGet
using SharpDX.DirectInput;
using AForge.Video;
using Newtonsoft.Json;

namespace AppControlRobot
{
    public partial class MainApp : Form
    {
        private string url_motors = "http://192.168.149.1:15001/";
        private string url_servos = "http://192.168.149.1:15002/";
        private string url_sensors = "http://192.168.149.1:15002/get_sensors";
        private string url_camera = "http://192.168.149.1:10300/video_feed";
        private string url_camera_detection = "http://192.168.149.1:10300/";

        private HttpClient httpClient = new HttpClient();
        private HttpClient get_sensors = new HttpClient();

        private DirectInput directInput;
        private Joystick joystick;

        private Timer buttonsTimer;
        private Timer controllerTimer;
        private Timer sensorsTimer;

        private int buttons_motor = 10;
        private int index_camera_option = 0;
        private int min_value_battery = 6264;
        private int max_value_battery = 8330;

        MJPEGStream streamCamera;

        public class Sensors_Int
        {
            public int Id { get; set; }
            public string Type_Sensor { get; set; }
            public string Type_Value { get; set; }
            public int Value { get; set; }
        }

        /*
        public class Sensors_Float
        {
            public int Id { get; set; }
            public string Type_Sensor { get; set; }
            public string Type_Value { get; set; }
            public float Value { get; set; }
        }

        public class Sensors_String
        {
            public int Id { get; set; }
            public string Type_Sensor { get; set; }
            public string Type_Value { get; set; }
            public string Value { get; set; }
        }
        */

        private string[] instructions =
        {
            "up",
            "left",
            "right",
            "down",
            "diagonalUL",
            "diagonalUR",
            "diagonalBL",
            "diagonalBR",
            "rotationL",
            "rotationR",
            //Poner las instructions de los motores arriba y los de servo abajo
            //Recuerda actualizar el variable de buttons_motor
            "up",
            "left",
            "right",
            "down",
            "resetServos",
            "buzzer",
            "pick_leave",
            "incline"
        };

        private string[] camera_instructions =
        {
            "cameraRaw",
            "detectRed",
            "detectGreen",
            "detectBlue"

        };

        public MainApp()
        {
            InitializeComponent();

            buttonsTimer = new Timer();
            buttonsTimer.Interval = 100; // Intervalo en milisegundos
            buttonsTimer.Tick += ButtonsTimer_Tick;

            controllerTimer = new Timer();
            controllerTimer.Interval = 100;
            controllerTimer.Tick += ControllerTimer_Tick;

            sensorsTimer = new Timer();
            sensorsTimer.Interval = 1000;
            sensorsTimer.Tick += SensorsTimer_Tick;
            sensorsTimer.Start();

            streamCamera = new MJPEGStream(url_camera);
            streamCamera.NewFrame += GetNewFrame; 
            streamCamera.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            directInput = new DirectInput();

            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
                joystickGuid = deviceInstance.InstanceGuid;

            if (joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
                    joystickGuid = deviceInstance.InstanceGuid;

            if(joystickGuid != Guid.Empty)
            {
                joystick = new Joystick(directInput, joystickGuid);
                joystick.Properties.BufferSize = 128;
                joystick.Acquire();
                controllerTimer.Start();
            }
            else
            {
                MessageBox.Show("No hay control conectado =(");
                Close();
                return;

            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            controllerTimer.Stop();
            sensorsTimer.Stop();
            joystick?.Unacquire();
            joystick?.Dispose();
            directInput?.Dispose();

        }

        private async void ButtonsTimer_Tick(object sender, EventArgs e)
        {
            var button = buttonsTimer.Tag as Button; // Obtener el botón asociado al temporizador
            if (button != null)
            {
                int buttonIndex = int.Parse(button.Tag.ToString());
                if (buttonIndex >= 0 && buttonIndex < instructions.Length)
                {
                    string url = (buttonIndex < buttons_motor) ? 
                        url_motors + instructions[buttonIndex] : 
                        url_servos + instructions[buttonIndex];

                    try
                    {
                        await httpClient.GetAsync(url);
                    }
                    catch (HttpRequestException ex)
                    {
                        buttonsTimer.Stop();
                        MessageBox.Show($"Error de conexión al servidor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void ControllerTimer_Tick(object sender, EventArgs e)
        {
            joystick.Poll();
            var data = joystick.GetBufferedData();
            foreach (var state in data)
            {
                if (state.Offset.ToString().Contains("PointOfViewControllers0"))
                {
                    switch (state.Value)
                    {
                        case 0: 
                            await httpClient.GetAsync(url_motors + "up");
                            break;
                        case 4500:
                            await httpClient.GetAsync(url_motors + "diagonalUR");
                            break;
                        case 9000:
                            await httpClient.GetAsync(url_motors + "right");
                            break;
                        case 13500:
                            await httpClient.GetAsync(url_motors + "diagonalBR");
                            break;
                        case 18000:
                            await httpClient.GetAsync(url_motors + "down");
                            break;
                        case 22500:
                            await httpClient.GetAsync(url_motors + "diagonalBL");
                            break;
                        case 27000:
                            await httpClient.GetAsync(url_motors + "left");
                            break;
                        case 31500:
                            await httpClient.GetAsync(url_motors + "diagonalUL");
                            break;
                        default: await httpClient.GetAsync(url_motors + "stopMotors");
                            break;

                    }
                }

                if (state.Offset.ToString().Contains("Buttons6") && state.Value == 128)
                    await httpClient.GetAsync(url_motors + "rotationL");
                if (state.Offset.ToString().Contains("Buttons7") && state.Value == 128)
                    await httpClient.GetAsync(url_motors + "rotationR");
                if ((state.Offset.ToString().Contains("Buttons6") || state.Offset.ToString().Contains("Buttons7")) && state.Value == 0)
                    await httpClient.GetAsync(url_motors + "stopMotors");

                if (state.Offset.ToString().Contains("Buttons0") && state.Value == 128)
                    await httpClient.GetAsync(url_servos + "left");
                else if (state.Offset.ToString().Contains("Buttons1") && state.Value == 128)
                    await httpClient.GetAsync(url_servos + "down");
                else if (state.Offset.ToString().Contains("Buttons2") && state.Value == 128)
                    await httpClient.GetAsync(url_servos + "right");
                else if (state.Offset.ToString().Contains("Buttons3") && state.Value == 128)
                    await httpClient.GetAsync(url_servos + "up");
                if (state.Offset.ToString().Contains("Buttons9") && state.Value == 128)
                    await httpClient.GetAsync(url_servos + "resetServos");

                if (state.Offset.ToString().Contains("Buttons4") && state.Value == 128)
                {
                    index_camera_option -= 1;
                    if (index_camera_option < 0) index_camera_option = 3;
                    update_color_detect();
                    await httpClient.GetAsync(url_camera_detection + camera_instructions[index_camera_option]);

                }
                if (state.Offset.ToString().Contains("Buttons5") && state.Value == 128)
                {
                    index_camera_option += 1;
                    if (index_camera_option > 3) index_camera_option = 0;
                    update_color_detect();
                    await httpClient.GetAsync(url_camera_detection + camera_instructions[index_camera_option]);
                }

            }
        }

        private async void SensorsTimer_Tick(object sender, EventArgs e)
        {

            try
            {
                HttpResponseMessage response = await get_sensors.GetAsync(url_sensors);
                response.EnsureSuccessStatusCode(); // Lanza una excepción si hay error

                string json = await response.Content.ReadAsStringAsync();

                var battery_values = JsonConvert.DeserializeObject<Sensors_Int[]>(json);

                foreach (var battery in battery_values)
                {
                    //MessageBox.Show($"ID: {battery.Id}, Type_sensor: {battery.Type_Sensor}, Type_Value: {battery.Type_Value} ,  Value: {battery.Value}");
                    float battery_percentage = 100 * (battery.Value - min_value_battery) / (max_value_battery - min_value_battery);
                    label_battery.Text = "Batería: " + Convert.ToString(battery_percentage) + "%";
                }
            }
            catch (HttpRequestException error)
            {
                MessageBox.Show($"Error al realizar la solicitud HTTP: {error.Message}");
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                buttonsTimer.Tag = button;
                buttonsTimer.Start();
            }
        }

        private void Btn_MouseUp(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                int buttonIndex = int.Parse(button.Tag.ToString());
                if (buttonIndex >= 0 && buttonIndex < buttons_motor)
                {
                    try
                    {
                        httpClient.GetAsync(url_motors + "stopMotors").Wait();
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Error de conexión al detener el movimiento del robot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            buttonsTimer.Stop();
        }

        private void GetNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmpvideo = (Bitmap)eventArgs.Frame.Clone();
            camara.Image = bmpvideo;
        }

        private void btn_raw_Click(object sender, EventArgs e)
        {
            httpClient.GetAsync(url_camera_detection + camera_instructions[0]).Wait();
            index_camera_option = 0;
            update_color_detect();
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            httpClient.GetAsync(url_camera_detection + camera_instructions[1]).Wait();
            index_camera_option = 1;
            update_color_detect();
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            httpClient.GetAsync(url_camera_detection + camera_instructions[2]).Wait();
            index_camera_option = 2;
            update_color_detect();
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            httpClient.GetAsync(url_camera_detection + camera_instructions[3]).Wait();
            index_camera_option = 3;
            update_color_detect();
        }

        private void update_color_detect()
        {
            switch (index_camera_option)
            {
                case 0: 
                    pictureBox_color_detect.BackColor = Color.Transparent;
                    break;
                case 1: 
                    pictureBox_color_detect.BackColor = Color.FromArgb(255,50,50);
                    break;
                case 2: 
                    pictureBox_color_detect.BackColor = Color.FromArgb(90,220,90);
                    break;
                case 3: 
                    pictureBox_color_detect.BackColor = Color.FromArgb(0,120,180);
                    break;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                MessageBox.Show("Recursos liberados");
                httpClient.Dispose();
                get_sensors.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
