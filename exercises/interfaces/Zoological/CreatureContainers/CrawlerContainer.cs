using System.Collections.Generic;

namespace Zoological
{
    public class CrawlerContainer
    {
        public List<ICrawlers> RoundUpCrawlers()
        {
            List<ICrawlers> CrawlersGroup = new List<ICrawlers>();

            CrawlersGroup.Add(new Earthworms());

            CrawlersGroup.Add(new TimberRattleSnake());

            return CrawlersGroup;

        }
    }
}