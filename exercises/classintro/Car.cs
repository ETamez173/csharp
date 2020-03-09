using System;

namespace classintro
{
    public class Car
    {
        // Field
        // Fields dont have a get; set; like a property and typically are private
        // Fields are lower camel cased and preficed by _underscore
        private int _milesDriven = 0;
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public bool NeedsMaintenance { get; set; } = false;

        ///// prop tab tab to get a property real quick

        // Computed Property
        // its a read only property, cannot be set
        public string Description
        {
            get
            {
                // this as computed property
                return $"{Year} { Make } { Model }";
            }

        }

        public bool IsClean { get; set; }

        // Methods 
        // use accessibility keyword, next decide the type to return VOID
        public void Drive(int miles)
        {

            _milesDriven += miles;

            if (_milesDriven > 10000)
            {
                NeedsMaintenance = true;
            }

        }

        public void Service()
        {
            NeedsMaintenance = false;
        }

        // Ramdom let us pass things to it and 3 diff ways to run it vid #3 1.52min

        // this called Method overloading we have method and its implemtend diff wasy but called
        // the same things and it takes diff arguments
        public void Service(bool addCleaningService)
        {
            NeedsMaintenance = false;

            if (addCleaningService)
            {
                IsClean = true;
            }
        }
        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Car or actully make a car
        /// new tells the complier to run this code - we are just testing with the consolewrite 
        /// will write it twice because their are two cars
        public Car()
        {
            Console.WriteLine("Inside the Contructor");

        }

        /// Constructor is particular type of Method, doesnt have a return type
        /// name of method is same as the name of the class
        /// this is the method that will run when ever I say "new" Car or actully make a car

        public Car(int milesDriven)
        {
            {
                _milesDriven = milesDriven;

            }
        }
        public Car(int milesDriven, string make, string model, int year)
        {
            // _milesDriven is the field & milesDriven is the parameter
            _milesDriven = milesDriven;
            Make = make;
            Model = model;
            Year = year;

        }

    }
}