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
//using SharpDX.DirectInput;
using SharpDX.XInput;
using AForge.Video;
using Newtonsoft.Json;

namespace AppControlRobot
{
    public partial class MainApp : Form
    {
        private string url_motors = "http://192.168.149.1:15001/";
        private string url_servos = "http://192.168.149.1:15002/";
        private string url_sensors = "http://192.168.149.1:15002/get_sensors";
        private string url_camera = "http://192.168.149.1:8081/video_feed";
        private string url_camera_detection = "http://192.168.149.1:8081/";

        private HttpClient httpClient = new HttpClient();
        private HttpClient get_sensors = new HttpClient();

        private Controller controller;

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
            "buzzer_on",
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
            controllerTimer.Interval = 150;
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
            controller = new Controller(UserIndex.One);

            if (controller.IsConnected)
            {
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
                        Close();
                        return;
                    }
                }
            }
        }

        private async void ControllerTimer_Tick(object sender, EventArgs e)
        {
            var state = controller.GetState();
            var buttons = state.Gamepad.Buttons;
            var LX = state.Gamepad.LeftThumbX;
            var LY = state.Gamepad.LeftThumbY;
            var RX = state.Gamepad.RightThumbX;
            var RY = state.Gamepad.RightThumbY;
            var leftTrigger = state.Gamepad.LeftTrigger;
            var rightTrigger = state.Gamepad.RightTrigger;

            if (buttons != GamepadButtonFlags.None)
            {
                switch (buttons)
                {
                    case GamepadButtonFlags.A:
                        await httpClient.GetAsync(url_servos + "pick_leave");
                        break;
                    case GamepadButtonFlags.B:
                        break;
                    case GamepadButtonFlags.X:
                        break;
                    case GamepadButtonFlags.Y:
                        break;
                    case GamepadButtonFlags.DPadUp:
                        break;
                    case GamepadButtonFlags.DPadDown:
                        break;
                    case GamepadButtonFlags.DPadLeft:
                        break;
                    case GamepadButtonFlags.DPadRight:
                        break;
                    case GamepadButtonFlags.RightShoulder:
                        index_camera_option += 1;
                        if (index_camera_option > 3) index_camera_option = 0;
                        update_color_detect();
                        await httpClient.GetAsync(url_camera_detection + camera_instructions[index_camera_option]);
                        break;
                    case GamepadButtonFlags.LeftShoulder:
                        index_camera_option -= 1;
                        if (index_camera_option < 0) index_camera_option = 3;
                        update_color_detect();
                        await httpClient.GetAsync(url_camera_detection + camera_instructions[index_camera_option]);
                        break;
                    case GamepadButtonFlags.Start:
                        await httpClient.GetAsync(url_servos + "resetServos");
                        break;
                    case GamepadButtonFlags.RightThumb:
                        await httpClient.GetAsync(url_servos + "buzzer_on");
                        break;
                    default:
                        break;

                }
            }
            else
            {
                await httpClient.GetAsync(url_servos + "buzzer_off");
            }


            if (leftTrigger == 255) await httpClient.GetAsync(url_motors + "rotationL");
            else if (rightTrigger == 255) await httpClient.GetAsync(url_motors + "rotationR");
            else if (LY >= 32000) await httpClient.GetAsync(url_motors + "up");
            else if (LY <= -32000) await httpClient.GetAsync(url_motors + "down");
            else if (LX >= 32000) await httpClient.GetAsync(url_motors + "right");
            else if (LX <= -32000) await httpClient.GetAsync(url_motors + "left");
            else if (LX > 1000 && LY > 1000) await httpClient.GetAsync(url_motors + "diagonalUR");
            else if (LX > 1000 && LY < -1000) await httpClient.GetAsync(url_motors + "diagonalBR");
            else if (LX < -1000 && LY < -1000) await httpClient.GetAsync(url_motors + "diagonalBL");
            else if (LX < -1000 && LY > 1000) await httpClient.GetAsync(url_motors + "diagonalUL");
            else await httpClient.GetAsync(url_motors + "stopMotors");

            if (RY >= 32767) await httpClient.GetAsync(url_servos + "up");
            else if (RY <= -32767) await httpClient.GetAsync(url_servos + "down");
            else if (RX >= 32767) await httpClient.GetAsync(url_servos + "right");
            else if (RX <= -32767) await httpClient.GetAsync(url_servos + "left");
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
                Close();
                return;
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
                        Close();
                        return;
                    }
                } else
                {
                    try
                    {
                        httpClient.GetAsync(url_servos + "buzzer_off").Wait();
                    }
                    catch (HttpRequestException ex)
                    {
                        MessageBox.Show($"Error de conexión al detener el buzzer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Close();
                        return;
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
