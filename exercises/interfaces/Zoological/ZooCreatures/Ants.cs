using System;

namespace Zoological
{
    public class Ants : IDiggers, ICrawlers

    {
        public bool Digsground { get; set; } = true;
        public void Crawl()
        {
            Console.WriteLine("Ant is now crawling");
        }
    }
}