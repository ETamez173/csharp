using System;

namespace planner {

    public class Building {

        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume {
            get {
                return Width * Depth * (3 * Stories);
            }

        }
        /////

        public Building (string address) {
            _address = address;

        }
        //Method 
        public void Construct () {
            _dateConstructed = DateTime.Now;
        }

        // this method takes an argument/parameter
        public void Purchase (string owner) {
            _owner = owner;

        }

        // methods for getting the desinger 
        public void Designer (string designer) {
            _designer = designer;

        }

        public void Print () {
            // Console.WriteLine ("++++++++++++++++++++++++");
            Console.WriteLine (_address);
            Console.WriteLine ($"Designed by {_designer}");
            Console.WriteLine ($"Constructed on {_dateConstructed}");
            Console.WriteLine ($"Owned by {_owner}");
            Console.WriteLine ($"{Volume} cubic meters of space");
            Console.WriteLine ("++++++++++++++++++++++++");
        }

    }

    /////

}