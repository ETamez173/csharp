using System;

namespace classintro {
    public class Car {
        // Field
        // Fields dont have a get; set; and typically private
        private int _milesDriven = 0;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public bool NeedsMaintenance { get; set; } = false;

        // Computed Property
        // its a read only property, cannot be set
        public string Description

        {

            get {

                return $"{Year} { Make } { Model }";
            }

        }

        public bool IsClean { get; set; }

        // Methods 
        public void Drive (int miles) {

            _milesDriven += miles;

            if (_milesDriven > 10000) {
                NeedsMaintenance = true;
            }

        }

        public void Service () {
            NeedsMaintenance = false;
        }

        public void Service (bool addCleaningService) {
            NeedsMaintenance = false;

            if (addCleaningService) {
                IsClean = true;
            }
        }
        // Constructor is particular type of Method
        // name of method is same as the class

        public Car () {
            Console.WriteLine ("Inside the Contructor");

        }

        // public Car (int _milesDriven) {
        //     {
        //         _milesDriven = milesDriven;

        //     }

        public Car (int milesDriven, string make, string model, int year) {

            _milesDriven = milesDriven;
            Make = make;
            Model = model;
            Year = year;

        }

    }

}