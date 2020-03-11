using System;

public class PaintedDog : IWalking
{

    public string Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Food { get; set; }

    ///
    /// these two below are implementing the IWalking interfaces
    public void Run()
    {
        Console.WriteLine("Animal is now running");
    }

    public void Walk()
    {
        Console.WriteLine("Animal is now walking");
    }
}