using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            // when I say "new" that's when i create an object - the class is only the blueprint
            // this works with the constructor and we can set the mileage on the car when created
            Car myFordBronco = new Car(40000, "Ford", "Bronco", 1982);

            // Car myFordBronco = new Car();
            // myFordBronco.Make = "Ford";
            // myFordBronco.Model = "Bronco";
            // myFordBronco.Year = 1982;

            // this more common wasy to declare class
            // saying "new" creates an instance of the Car class 
            Car mySuburu = new Car()
            {
                Make = "Suburu",
                Model = "Forrester",
                Year = 1999
            };

            // Console.WriteLine(myFordBronco.Description);
            // Console.WriteLine(mySuburu.Description);

            // we are invoking myFordBronco is an instance of the Car class
            // we invoked the Drive method and passed in the number 60 as the pararmeter 
            myFordBronco.Drive(9999);
            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");
            myFordBronco.Drive(60);
            Console.WriteLine($"Bronco needs service: {myFordBronco.NeedsMaintenance}");

            myFordBronco.Service(true);
        }

    }
}