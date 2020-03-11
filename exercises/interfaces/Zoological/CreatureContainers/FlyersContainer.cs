using System;
using System.Collections.Generic;

namespace Zoological
{
    public class FlyersContainer
    {
        public List<IFlyers> RoundUpFlyers()
        {
            List<IFlyers> FlyersGroup = new List<IFlyers>();

            FlyersGroup.Add(new Parakeets());
            FlyersGroup.Add(new Finches());

            return FlyersGroup;

        }
    }
}