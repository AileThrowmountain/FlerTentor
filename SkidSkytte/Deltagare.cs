using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkidSkytte
{
    class Deltagare
    { 
   
        public Deltagare(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Deltagare()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Result { get; set; } = new int[5];
 
        public string Number { get; set; }

        public override string ToString()
        {
            return ($"{Number} {FirstName} {LastName}");
        }

     

    }
}
