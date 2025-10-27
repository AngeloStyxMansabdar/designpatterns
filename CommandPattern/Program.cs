using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("Living Room Fan");
            GarageDoor garageDoor = new GarageDoor(new Light("Garage"));
            Stereo stereo = new Stereo();

            // Define and instantiate an Off and On command for each Vendor class
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            CeilingFanLowCommand ceilingFanLow = new CeilingFanLowCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(garageDoor);

            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);


            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */
            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOff);
            remoteControl.SetCommand(4, ceilingFanLow, ceilingFanOff);
            remoteControl.SetCommand(5, ceilingFanMedium, ceilingFanOff);
            remoteControl.SetCommand(6, ceilingFanHigh, ceilingFanOff);

            Console.WriteLine(remoteControl);

            Console.WriteLine("// Executing actions \\");
            Console.WriteLine("1) Turn on Kitchen (slot 1)");
            remoteControl.OnButtonWasPushed(1); // kitchen on

            Console.WriteLine("2) Turn on Living Room (slot 0)");
            remoteControl.OnButtonWasPushed(0); // living room on

            Console.WriteLine("3) Turn off Kitchen (slot 1)");
            remoteControl.OffButtonWasPushed(1); // kitchen off

            Console.WriteLine("4) Open Garage (slot 2)");
            remoteControl.OnButtonWasPushed(2); // garage up

            Console.WriteLine("\n // Undoing actions \\");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"\nUndo #{i + 1}:");
                remoteControl.UndoButtonWasPushed();
            }

            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}