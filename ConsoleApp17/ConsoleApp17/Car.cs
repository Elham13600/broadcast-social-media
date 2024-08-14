using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public override string ToString()
        {
            return $"{Make} {Model}";
        }
    }
}
