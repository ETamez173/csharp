using System;

namespace Zoological
{
    public class TimberRattleSnake : ICrawlers, IDiggers

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these two below are implementing the ICrawler and IDiggers interfaces
        public void Crawl()
        {
            Console.WriteLine("Creature is now crawling");
        }

        public bool Digsground { get; set; } = true;
    }
}