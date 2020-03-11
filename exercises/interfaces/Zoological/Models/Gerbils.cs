using System;

namespace Zoological
{
    public class Gerbils : IDiggers, IWalking

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these two below are implementing the IWalking and IDiggers interfaces
        public bool Digsground { get; set; } = true;

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