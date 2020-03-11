using System;

namespace Zoological
{
    class SeaTurtle : IWalking, ISwimming
    {

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