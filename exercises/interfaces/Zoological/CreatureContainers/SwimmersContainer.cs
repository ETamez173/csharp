using System;
using System.Collections.Generic;

namespace Zoological
{
    public class SwimmersContainer
    {
        public List<ISwimming> RoundUpSwimmers()
        {
            List<ISwimming> SwimmersGroup = new List<ISwimming>();

            SwimmersGroup.Add(new Bettafish());
            SwimmersGroup.Add(new CopperheadSnake());

            return SwimmersGroup;

        }
    }
}