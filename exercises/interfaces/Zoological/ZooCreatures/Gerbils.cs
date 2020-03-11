using System;

namespace Zoological
{
    public class Gerbils : IDiggers, IWalking

    {
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