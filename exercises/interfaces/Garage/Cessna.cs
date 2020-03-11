namespace Garage
{
    public class Cessna : IGasPowered
    { // Propellor light aircraft

        // the first property is defined in the interface
        public void RefuelTank() { }

        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

    }
}