using System;
using System.Collections.Generic;

namespace Zoological
{
    class Program
    {
        static void Main(string[] args)
        {

            Parakeets myParakeet = new Parakeets()
            {
                Species = "Budgerigar",
                Name = "Sqawkey",
                Color = "lime green",
                Food = "Fruit and Nuts",
                Fliesaround = true
            };
            Earthworms myEarthworm = new Earthworms()
            {
                Species = "Common Earthworm",
                Name = "Wormy",
                Color = "tan",
                Food = "Dirt",
                Digsground = true
            };
            Terrapins myTerrapin = new Terrapins()
            {
                Species = "Southern River Terrapin",
                Name = "Steve",
                Color = "Black",
                Food = "Algae",
                // Swimmer = true,
                // Crawler = true
            };
            TimberRattleSnake myRattlesnake = new TimberRattleSnake()
            {
                Species = "Diamondback Rattlesnake",
                Name = "Bitey",
                Color = "Brown",
                Food = "Mice",
                // Crawler = true
            };
            Mice myMouse = new Mice()
            {
                Species = "Deer Mouse",
                Name = "Mr. Wiggles",
                Color = "Tan",
                Food = "Seed and Nuts",
                Digsground = true,
                // Crawler = true
            };
            Ants myAnt = new Ants()
            {
                Species = "Black Garden Ant",
                Name = "Sgt. Stiggs",
                Color = "Black",
                Food = "Crumbs",
                // Crawler = true,
                Digsground = true
            };
            Finches myFinch = new Finches()
            {
                Species = "Common Cactus Finch",
                Name = "Gertrude",
                Color = "Black",
                Food = "Worms",
                Fliesaround = true
            };
            Bettafish myBetaFish = new Bettafish()
            {
                Species = "Combtail Betta",
                Name = "Willis",
                Color = "Blue and Purple",
                Food = "Fish Flakes",
                // Swimmer = true
            };
            CopperheadSnake myCopperhead = new CopperheadSnake()
            {
                Species = "Australian Copperhead",
                Name = "Greg",
                Color = "Grey and Brown",
                Food = "Mice",
                // Crawler = true,
                // Swimmer = true
            };
            Gerbils myGerbil = new Gerbils()
            {
                Species = "Fat-Tailed Gerbil",
                Name = "Tan",
                Color = "Bill",
                Food = "Seeds and Nuts",
                Digsground = true,
                // Crawler = true
            };

            // Lists of Animals

            List<Ants> Ants = new List<Ants>();
            List<Bettafish> BettaFish = new List<Bettafish>();
            List<CopperheadSnake> Copperhead = new List<CopperheadSnake>();
            List<Earthworms> Earthworms = new List<Earthworms>();
            List<Finches> Finches = new List<Finches>();
            List<Gerbils> Gerbils = new List<Gerbils>();
            List<Mice> Mice = new List<Mice>();
            List<Parakeets> Parakeets = new List<Parakeets>();
            List<TimberRattleSnake> Rattlesnake = new List<TimberRattleSnake>();
            List<Terrapins> Terrapins = new List<Terrapins>();

            // Lists of animals added to Containers 

            // CrawlersContainer

            List<ICrawlers> crawlersGroup = new List<ICrawlers>();

            crawlersGroup.Add(new Earthworms());
            crawlersGroup.Add(new TimberRattleSnake());
            crawlersGroup.Add(new Ants());

            // DiggersContainer

            List<IDiggers> DiggersGroup = new List<IDiggers>();

            DiggersGroup.Add(new Ants());
            DiggersGroup.Add(new Gerbils());
            DiggersGroup.Add(new Mice());
            DiggersGroup.Add(new Earthworms());
            DiggersGroup.Add(new Terrapins());
            DiggersGroup.Add(new TimberRattleSnake());
            DiggersGroup.Add(new CopperheadSnake());

            // FlyersContainer

            List<IFlyers> FlyersGroup = new List<IFlyers>();

            FlyersGroup.Add(new Parakeets());
            FlyersGroup.Add(new Finches());

            // SwimmersContainer

            List<ISwimming> SwimmersGroup = new List<ISwimming>();

            SwimmersGroup.Add(new Bettafish());
            SwimmersGroup.Add(new CopperheadSnake());

            // WalkersContainer

            List<IWalking> WalkersGroup = new List<IWalking>();
            WalkersGroup.Add(new Gerbils());
            WalkersGroup.Add(new Mice());
            WalkersGroup.Add(new Terrapins());
            WalkersGroup.Add(new Parakeets());
            WalkersGroup.Add(new Terrapins());

            Console.WriteLine("Hey it didnt blow up!");

        }

    }
}