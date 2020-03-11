using System;

namespace Zoological
{
    public class CopperheadSnake : ICrawlers, IDiggers, ISwimming

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these three below are implementing the Idiggers and ICrawlers 
        /// and ISwimmers interfaces
        public void Crawl()
        {
            Console.WriteLine("Snake is now crawling");
        }

        public bool Digsground { get; set; } = true;
        public void Swim()
        {
            Console.WriteLine("Snake is now swimming");
        }
        public int MaximumDepth { get; } = 100;

    }
}