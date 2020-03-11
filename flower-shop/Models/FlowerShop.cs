using System.Collections.Generic;

namespace FlowerShop
{

    public class FlowerShop
    {

        public List<Rose> Roses = new List<Rose>();
        public List<Tulip> Tulips = new List<Tulip>();
        public List<Sunflower> Sunflowers = new List < Sunflower();
        public List<Lilly> Lillies = new List<Lilly>();

        public List<IMothersDay> MakeMothersDayArrangement()
        {

            List<IMothersDay> Arrangement = new List<IMothersDay>();
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Lilly());
            Arrangement.Add(new Lilly());
            Arrangement.Add(new Lilly());

            return Arrangement;
        }

        /// this uses the IBirthday interface which two flowers classes have
        /// a pubic Method that will return a list of types that implement 
        // the IBirthday interface
        public List<IBirthday> MakeBirthdayArrangement()
        {
            List<IBirthday> Arrangement = new List<IBirthday>();

            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Sunflower());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();

            Arrangement.Add(new Mildew());
            Arrangement.Add(new Mildew());
            Arrangement.Add(new Mildew());

            return Arrangement;

        }

    }
}