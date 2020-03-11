using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create some electric vehicles, add them to a List
                and then iterate the List to charge all of their
                batteries.
            */

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            // List<IElectricPowered> electricVehicles = new List<IElectricPowered>()
            // {
            //     fx,
            //     fxs,
            //     modelS
            // };

            /*
                This can only hold individual motorcycles. You can't
                add the Tesla to this list. It's a different type.
                This is invalid code. The `modelS` is not of type Zero.
            */

            // this is the old code that wont allow separate classes in one list
            // List<Zero> electricVehicles = new List<Zero>() { fx, fxs, modelS };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();
            electricVehicles.Add(fx);
            electricVehicles.Add(fxs);
            electricVehicles.Add(modelS);

            Console.WriteLine($" {electricVehicles}");

            electricVehicles.ForEach(ev => ev.ChargeBattery());

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */
            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasPowered> gasVehicles = new List<IGasPowered>();

            gasVehicles.Add(ram);
            gasVehicles.Add(cessna150);
            // ram,
            // cessna150

            gasVehicles.ForEach(gv => gv.RefuelTank());

        }
    }
}