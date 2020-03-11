using System;

namespace Zoological
{
    public class TimberRattleSnake : ICrawlers, IDiggers

    {

        public void Crawl()
        {
            Console.WriteLine("Creature is now crawling");
        }

        public bool Digsground { get; set; } = true;
    }
}