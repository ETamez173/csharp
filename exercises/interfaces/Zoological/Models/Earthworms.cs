using System;

namespace Zoological
{
    public class Earthworms : ICrawlers, IDiggers

    {

        public string Species { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Food { get; set; }

        ///
        /// these below are implementing the Idiggers and ICrawlers 

        public void Crawl()
        {
            Console.WriteLine("Creature is now crawling");
        }

        public bool Digsground { get; set; } = true;
    }
}