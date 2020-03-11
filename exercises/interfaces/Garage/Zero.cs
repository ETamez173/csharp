// You tell the compiler that a class must
// implement an interface by putting a colon after the class name, followed by the interface.
namespace Garage
{
    public class Zero : IElectricPowered
    {

        // Electric motorcycle

        // the first two properties are defined in the interface
        public double BatteryKWh { get; set; }
        public void ChargeBattery() { }

        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

    }
}