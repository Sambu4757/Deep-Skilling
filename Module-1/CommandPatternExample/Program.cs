using System;

class Program
{
    static void Main()
    {
        Light light = new Light();

        ICommand lightOn =
            new LightOnCommand(light);

        ICommand lightOff =
            new LightOffCommand(light);

        RemoteControl remote =
            new RemoteControl();

        remote.SetCommand(lightOn);
        remote.PressButton();

        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}