using System;
using System.Collections.Generic;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose();
            Sunflower sunFlower = new Sunflower();
            Tulip tulip = new Tulip();
            Lilly lilly = new Lilly();

            FlowerShop MacsFlowerShop = new FlowerShop();
            List<IBirthday> Arrangement = MacsFlowerShop.MakeBirthdayArrangement();

        }

    }
}