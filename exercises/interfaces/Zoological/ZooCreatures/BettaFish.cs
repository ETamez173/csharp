using System;

namespace Zoological
{
    public class Bettafish : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("Fish is now swimming");
        }

        public int MaximumDepth { get; } = 100;
    }
}