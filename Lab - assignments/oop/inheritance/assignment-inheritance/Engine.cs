using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Engine
    {
        public string Manufacturer;
        public int HorsePower;

        public Engine(string manufacturer, int power)
        {
            Manufacturer = manufacturer;
            HorsePower = power;
        }

        public void ShowEngineDetails()
        {
            Console.WriteLine($"Engine Manufactured by: {Manufacturer},  HorsePower: {HorsePower}");
        }
    }

    public class Car2
    {
        public string model;
        public Engine engine;

        public Car2(string Model, Engine Engine)
        {
            model = Model;
            engine = Engine;
        }

        public void CarDetails()
        {
            Console.WriteLine($"Car model: {model}");
            engine.ShowEngineDetails();
        }
    }
}
