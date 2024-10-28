using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    abstract class Vehicle2
    {
        public abstract void Drive();
        
    }

    class Car : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("Driving car");
        }
    }

    class Bike : Vehicle2
    {
        public override void Drive()
        {
            Console.WriteLine("Riding bike");
        }
    }
}
