using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningTenta
{
    class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }


        public override string ToString()
        {
            return ($"{Address}");
        }
    }
}
