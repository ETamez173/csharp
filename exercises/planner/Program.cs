using System;

namespace planner {
    class Program {
        static void Main (string[] args) {
            Building FiveOneTwoEigth = new Building ("512 8th Avenue")

            {
                Width = 100,
                Depth = 200,
                Stories = 3,
            };

            // Car mySuburu = new Car () {
            //     Make = "Suburu",

            //     Model = "Forrester",
            //     Year = 1999
            // };

            FiveOneTwoEigth.Construct ();

            FiveOneTwoEigth.Purchase ("Joe Blow");
            FiveOneTwoEigth.Designer ("Sue Jones");
            // FiveOneTwoEigth.Print ();

            Building OneTwoThreeMain = new Building ("123 Main Street")

            {
                Width = 150,
                Depth = 400,
                Stories = 5,
            };

            // Car mySuburu = new Car () {
            //     Make = "Suburu",

            //     Model = "Forrester",
            //     Year = 1999
            // };

            FiveOneTwoEigth.Construct ();

            FiveOneTwoEigth.Purchase ("Joe Blow");
            FiveOneTwoEigth.Designer ("Sue Jones");
            // FiveOneTwoEigth.Print ();

            OneTwoThreeMain.Construct ();
            OneTwoThreeMain.Purchase ("Mike Monybags");
            OneTwoThreeMain.Designer ("Jimmy Straightline");
            // OneTwoThreeMain.Print ();

            City Boro = new City ("Murfreesboro", "John Miller", 1867);
            Console.WriteLine ("++++++++++++++++++++++++");
            Console.WriteLine (Boro.CityName);
            Console.WriteLine (Boro.Mayor);
            Console.WriteLine (Boro.DateEstablished);

            Console.WriteLine ("++++++++++++++++++++++++");
            //   Console.WriteLine (Buildings.building);

            Boro.AddBuildingToCity (OneTwoThreeMain);
            Boro.AddBuildingToCity (FiveOneTwoEigth);

            foreach (Building building in Boro.Buildings) {
                // Console.WriteLine (...);
                building.Print ();
            }

        }
    }
}