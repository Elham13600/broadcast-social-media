using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Car
    {
        public int Speed;

        public Car(int startSpeed)
        { 
        Speed = startSpeed;
        }

        public void IncreaseSpeed()
        {
            Speed += 10;
        }

        public void stop()
        {
            Speed = 0;
        }
    }
}
