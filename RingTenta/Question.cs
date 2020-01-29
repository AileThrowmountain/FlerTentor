using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingTenta
{
    class Question
    {
        public Question(int number)
        {
            Number = number;
            Points = 1;

        }

        public bool Correct { get; set; }
        public bool IsTaken { get; set; }
        public int Number { get; set; }
        public int Points { get; set; }

        public override string ToString()
        {
            return ($"Fråga nummer: {Number}");
        }
    }

}
