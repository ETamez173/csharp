using System;
using InheritanceIntro;

public class Tesla : Vehicle
{
    // Electric car
    public double BatteryKWh { get; set; }
    // public string MainColor { get; set; }
    // public int MaximumOccupancy { get; set; }

    public void ChargeBattery() { }

    public override void Drive()
    {
        Console.WriteLine("Rumble Rumble!");
    }

    public override string ToString()
    {
        return "This is my tesla";
    }
}