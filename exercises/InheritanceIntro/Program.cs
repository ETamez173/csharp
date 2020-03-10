using System;

namespace InheritanceIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBike = new Zero();
            // I can still reference the inherited property
            myBike.MainColor = "Black";
            myBike.MaxOccupancy = 2;

            var myTesla = new Tesla();
            myTesla.MainColor = "Midnight Silver";
            myTesla.MaxOccupancy = 8;

            var myRam = new Ram();
            myRam.MainColor = "Silver";
            myRam.MaxOccupancy = 6;

            var myCessna = new Cessna();
            myCessna.MainColor = "White";
            myCessna.MaxOccupancy = 5;

            myBike.Drive();
            myTesla.Drive();
            myRam.Drive();
            myCessna.Drive();

        }
    }
}