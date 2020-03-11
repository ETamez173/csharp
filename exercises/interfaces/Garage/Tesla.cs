namespace Garage
{
    public class Tesla : IElectricPowered
    // If a class implements an interface, then it must define a method, 
    // property, or event for each one defined in the interface.
    { // Electric car

        // the first two properties are defined in the interface
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

    }
}