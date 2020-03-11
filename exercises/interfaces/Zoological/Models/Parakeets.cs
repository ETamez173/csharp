using System;

namespace Zoological
{

    public class Parakeets : IFlyers, IWalking
    /// these two below are implementing the IFlyers interfaces
    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        public bool Fliesaround { get; set; } = true;

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

    }
}