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

            // Test the pressing of Buttons here. Don't forget to test the Undo 
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(5);
            remoteControl.OffButtonWasPushed(5);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);

            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);
            remoteControl.UndoButtonWasPushed();
            Console.WriteLine("");
            //Console.WriteLine(remoteControl);



        }
    }
}