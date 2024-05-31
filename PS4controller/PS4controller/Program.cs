/*
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;

namespace PS4controller
{
    class Program
    {
        static void Main(string[] args)
        {
            var directInput = new DirectInput();

            var joystickGuid = Guid.Empty;

            foreach (var deviceInstance in directInput.GetDevices(
                    DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices
                ))
                joystickGuid = deviceInstance.InstanceGuid;

            if(joystickGuid == Guid.Empty)
                foreach (var deviceInstance in directInput.GetDevices(
                    DeviceType.Joystick, DeviceEnumerationFlags.AllDevices
                ))
                    joystickGuid = deviceInstance.InstanceGuid;

            if(joystickGuid == Guid.Empty)
            {
                Console.WriteLine("No hay control conectado =(");
                Environment.Exit(1);
            }

            var joystick = new Joystick(directInput, joystickGuid);

            Console.WriteLine("El control es {0}", joystickGuid);

            joystick.Properties.BufferSize = 128;

            joystick.Acquire();

            while (true)
            {
                joystick.Poll();
                var data = joystick.GetBufferedData();

                foreach (var state in data)
                {
                    //if(state.Offset.ToString().Contains("Buttons0"))
                    Console.WriteLine(state);
                }
            }
        }   
    }zz
}
*/

using System;
using System.Threading;
using SharpDX.XInput;

namespace XboxController
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller(UserIndex.One);

            if (!controller.IsConnected)
            {
                Console.WriteLine("No hay control conectado =(");
                Environment.Exit(1);
            }

            Console.WriteLine("El control está conectado.");    

            while (true)
            {
                var state = controller.GetState();
                var buttons = state.Gamepad.Buttons;

                // Verifica y muestra los botones específicos presionados
                if (buttons != GamepadButtonFlags.None)
                {
                    Console.WriteLine("Buttons pressed: " + buttons);

                    if ((buttons & GamepadButtonFlags.A) != 0)
                        Console.WriteLine("Button A pressed");
                    if ((buttons & GamepadButtonFlags.B) != 0)
                        Console.WriteLine("Button B pressed");
                    if ((buttons & GamepadButtonFlags.X) != 0)
                        Console.WriteLine("Button X pressed");
                    if ((buttons & GamepadButtonFlags.Y) != 0)
                        Console.WriteLine("Button Y pressed");
                    if ((buttons & GamepadButtonFlags.LeftShoulder) != 0)
                        Console.WriteLine("Left Shoulder pressed");
                    if ((buttons & GamepadButtonFlags.RightShoulder) != 0)
                        Console.WriteLine("Right Shoulder pressed");
                    if ((buttons & GamepadButtonFlags.Back) != 0)
                        Console.WriteLine("Back button pressed");
                    if ((buttons & GamepadButtonFlags.Start) != 0)
                        Console.WriteLine("Start button pressed");
                    if ((buttons & GamepadButtonFlags.LeftThumb) != 0)
                        Console.WriteLine("Left Thumbstick button pressed");
                    if ((buttons & GamepadButtonFlags.RightThumb) != 0)
                        Console.WriteLine("Right Thumbstick button pressed");
                }

                // Muestra los estados de los thumbsticks solo si hay movimiento
                var leftThumbX = state.Gamepad.LeftThumbX;
                var leftThumbY = state.Gamepad.LeftThumbY;
                var rightThumbX = state.Gamepad.RightThumbX;
                var rightThumbY = state.Gamepad.RightThumbY;

                if (leftThumbX != 0 || leftThumbY != 0)
                    Console.WriteLine($"Left Thumbstick: X={leftThumbX}, Y={leftThumbY}");
                if (rightThumbX != 0 || rightThumbY != 0)
                    Console.WriteLine($"Right Thumbstick: X={rightThumbX}, Y={rightThumbY}");

                // Muestra los estados de los triggers solo si se utilizan
                var leftTrigger = state.Gamepad.LeftTrigger;
                var rightTrigger = state.Gamepad.RightTrigger;

                if (leftTrigger > 0)
                    Console.WriteLine($"Left Trigger: {leftTrigger}");
                if (rightTrigger > 0)
                    Console.WriteLine($"Right Trigger: {rightTrigger}");

                Thread.Sleep(1000);
            }
        }
    }
}
