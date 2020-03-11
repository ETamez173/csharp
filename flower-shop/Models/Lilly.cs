using System;

namespace FlowerShop
{

    public class Lilly : IMothersDay
    {

        public string Color { get; set; }

        public string Name { get; set; }
        public string PetalCount { get; set; }

        public string Species { get; set; }

        public int Cost { get; set; }

        public int WaterSchedule { get; set; }

        public int Thorny { get; set; }

        public int Fragrant { get; set; }

        // Mothers Day boquet
        public int StemLength { get; set; }

        public override string ToString()

        {
            return $"A fanciful {Color} Lilly with {PetalCount} petals.";
        }

    }
}