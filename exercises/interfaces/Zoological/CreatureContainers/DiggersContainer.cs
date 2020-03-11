using System;
using System.Collections.Generic;

namespace Zoological
{
    public class DiggersContainer
    {
        public List<IDiggers> RoundUpDiggers()
        {
            List<IDiggers> DiggersGroup = new List<IDiggers>();

            DiggersGroup.Add(new Ants());
            DiggersGroup.Add(new Gerbils());
            DiggersGroup.Add(new Mice());
            DiggersGroup.Add(new Earthworms());
            DiggersGroup.Add(new Terrapins());
            DiggersGroup.Add(new TimberRattleSnake());
            DiggersGroup.Add(new CopperheadSnake());

            return DiggersGroup;

        }
    }
}