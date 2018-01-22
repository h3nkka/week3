using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();
            bool result = true;
            while (result == true)
            {
                Console.WriteLine("Current amplifier volume: {0}", vahvistin.Volume);
                Console.WriteLine("Input a new volume.");
                if (result = Int32.TryParse(Console.ReadLine(), out int input))
                vahvistin.Volume = input;
            }
        }
    }
}
