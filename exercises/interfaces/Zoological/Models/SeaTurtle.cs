using System;

namespace Zoological
{
    class SeaTurtle : IWalking, ISwimming
    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these two below are implementing the IWalking and ISwimmers interfaces
        public void Run()
        {
            Console.WriteLine("Animal is now running");
        }

        public void Walk()
        {
            Console.WriteLine("Animal is now walking");
        }

        public void Swim()
        {
            Console.WriteLine("Animal is now swimming");
        }
        public int MaximumDepth { get; } = 100;

    }
}