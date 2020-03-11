namespace Garage
{
    public interface IElectricPowered
    {
        double BatteryKWh { get; set; }

        void ChargeBattery();
    }
}

//  It's important to note that you cannot put
//  logic in an interface.
//  An interface simply lists the rules, or the contract, that a class must abide by. How the class 
//  abides by the rules is up to the individual class.

//For example, this interface says that any class that implements it must have a BatteryKHw property. The developer can choose...

// If it has a getter and setter
// If the getter/setter have specific logic
// Those are implementation details that an interface doesn't care about.