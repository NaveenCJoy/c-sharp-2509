using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Vehicle3
    {
        public string Brand;

        public Vehicle3(string brand)
        {
            Brand = brand;
        }
    }

    public class Car3 : Vehicle3
    {
        public string Model;

        public Car3(string brand ,string model) : base(brand)
        {
            Model = model;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Car Brand: {Brand}  Car Model: {Model}");
        }
    }
}
