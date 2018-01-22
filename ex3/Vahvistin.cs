using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    public class Vahvistin
    {
        private int volume = 0;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 100)
                {
                    volume = 100;
                    Console.WriteLine("Set volume to max. (100)");
                }
                else if (value < 0)
                {
                    volume = 0;
                    Console.WriteLine("Set volume to min. (0)");
                }
                else
                {
                    volume = value;
                    Console.WriteLine("Set volume to " + value + ".");
                }
            }
        }
    }
}
