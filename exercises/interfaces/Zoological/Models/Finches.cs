using System;

namespace Zoological
{
    public class Finches : IFlyers

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these below are implementing the IFlyers interface 

        public bool Fliesaround { get; set; } = true;

    }
}