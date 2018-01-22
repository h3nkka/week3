using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            while (result == true)
            {
                Console.WriteLine("The current elevator floor is {0}.", Hissi.Floor);
                Console.WriteLine("Input a number (1-5) to change the floor.");
                if(result = Int32.TryParse(Console.ReadLine(), out int input))
                    Hissi.Floor = input;
            }
        }
    }
}
