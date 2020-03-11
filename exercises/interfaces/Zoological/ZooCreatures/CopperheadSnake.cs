using System;

namespace Zoological
{
    public class CopperheadSnake : ICrawlers, IDiggers, ISwimming

    {

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