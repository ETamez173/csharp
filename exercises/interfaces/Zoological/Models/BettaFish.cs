using System;

namespace Zoological
{
    public class Bettafish : ISwimming
    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        /// these two below are implementing the ISwimmeing interface

        public void Swim()
        {
            Console.WriteLine("Fish is now swimming");
        }

        public int MaximumDepth { get; } = 100;
    }
}