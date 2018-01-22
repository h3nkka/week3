using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class TestTank
    {
        static void Main(string[] args)
        {
            Tank tank = new Tank();
            tank.Name = "Tankki";
            tank.Type = "M1 Abrams";
            tank.CrewCount = 3;
            tank.CrewCount = 0;

            Console.WriteLine(tank.Name);
            Console.WriteLine(tank.Type);
            Console.WriteLine("CrewCount: " + tank.CrewCount);
            Console.WriteLine("Speed: " + tank.Speed);
            Console.WriteLine("MaxSpeed: " + tank.SpeedMax);

            tank.AccelerateTo(100);
            Console.WriteLine("Speed: " + tank.Speed);
            tank.AccelerateTo(101);
            tank.SlowTo(-1);
            tank.SlowTo(0);
            
            Console.ReadKey(true);
        }
    }
}
