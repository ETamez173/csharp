using System;

namespace classintro {
    class Program {
        static void Main (string[] args) {
            Car myFordBronco = new Car (40000, "Ford", "Bronco", 1982);
            // myFordBronco.Make = "Ford";
            // myFordBronco.Model = "Bronco";
            // myFordBronco.Year = 1982;

            Car mySuburu = new Car () {
                Make = "Suburu",
                Model = "Forrester",
                Year = 1999
            };

            // Console.WriteLine (myFordBronco.Description);
            // Console.WriteLine (mySuburu.Description);

            myFordBronco.Drive (9999);
            Console.WriteLine ($"Bronco needs service: {myFordBronco.NeedsMaintenance}");
            myFordBronco.Drive (60);
            Console.WriteLine ($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service (true);
        }

    }
}