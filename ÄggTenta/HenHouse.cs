using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÄggTenta
{
    class HenHouse
    {
        public List<Hen> Hens { get; set; } = new List<Hen>();
        public int Stable { get; set; }


        public List<Egg> CollectEggs()
        {
            List<Egg> eggs = new List<Egg>();
            foreach (Hen hen in Hens)
            {
                Egg egg = hen.LayEgg2();
                if (egg != null)
                {
                    eggs.Add(egg);
                }
            }
            return eggs;
        }



        public int DailyHarvest()
        {
            int countEggs = 0;
            foreach (var hen in Hens)
            {
                if (hen.LayEgg() == 1)
                {
                    countEggs++;
                }
            }
            return countEggs;
        }

        public HenHouse(int numberOfHens)
        {

            for (int i = 0; i < numberOfHens; i++)
            { 
                Hens.Add(new Hen());
            }
        }
    }
}
