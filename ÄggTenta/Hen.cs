using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÄggTenta
{
    class Hen
    {
        public string Breed { get; set; }
        public double Weight { get; set; }

        /*
         * Lägger metoden här för att hönan värper äggen och det är där jag vill komma åt dom
         *
         *
         */
     

        private static readonly Random random = new Random();
        public int LayEgg()
        {
            
            
            int egg = random.Next(0, 101);

            if (egg <= 48)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public Egg LayEgg2()
        {
            if (random.Next(1, 101) <= 48)
            {
                return new Egg(random.Next(20, 81));
            }
            else
            {
                return null;
            }
        }
    }
}
