using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÄggTenta
{
    class Egg
    {

        private static readonly Random random = new Random();
        public int Weight { get; set; }

 public Egg(int weight)
        {
            Weight = weight;
        }

        public Egg()
        {

        }
    }
}
