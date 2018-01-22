using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public static class Hissi
    {
        private static int floor = 1;
        public static int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value > 0 && value <= 5)
                    floor = value;
                else
                    Console.WriteLine("Invalid floor. Input floors from 1 to 5.");
            }
        }
    }
}
