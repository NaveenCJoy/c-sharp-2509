using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Animal2
    {
        public string name;

        public Animal2(string Name)
        {
            name = Name;
        }

        public void Eat()
        {
            Console.WriteLine($"{name} is eating...");
        }
    }

    public class Dog2 : Animal2
    {
        public Dog2(string name) : base(name) { }

        public void Bark()
        {
            Console.WriteLine($"{name} is barking");
        }
        
    }
}
