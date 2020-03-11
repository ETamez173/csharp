using System;

namespace Zoological
{
    public class Ants : IDiggers, ICrawlers

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        /// these two below are implementing the Idiggers and ICrawlers interface
        public bool Digsground { get; set; } = true;
        public void Crawl()
        {
            Console.WriteLine("Ant is now crawling");
        }
    }
}