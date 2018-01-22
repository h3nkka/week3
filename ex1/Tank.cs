using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Tank
    {
        private string name;
        private string type;
        private int crewCount;
        private float speed = 0;
        private readonly float speedMax = 100;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int CrewCount
        {
            get
            {
                return crewCount;
            }
            set
            {
                if (value >= 2 && value <= 6)
                    crewCount = value;
                else
                    Console.WriteLine("CrewCount must be between 2 and 6.");
            }
        }
        public float Speed
        {
            get
            {
                return speed;
            }
        }
        public float SpeedMax
        {
            get
            {
                return speedMax;
            }
        }

        public void AccelerateTo(float input)
        {
            if (speed >= 0 && speed <= speedMax)
                speed = input;
            else
                Console.WriteLine("Speed must be between 0 and 100.");
        }
        public void SlowTo(float input)
        {
            if (speed >= 0 && speed <= speedMax)
                speed = input;
            else
                Console.WriteLine("Speed must be between 0 and 100.");
        }
    }
}
