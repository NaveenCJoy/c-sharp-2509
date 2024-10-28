using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Animal
    {
        public string name;
        public Animal(string Name)
        {
            this.name = Name;
        }

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        
        public void Bark()
        {
            Console.WriteLine($"{name} is barking");
        }
    }

    public class Puppy : Dog
    {
        public Puppy(string name) : base(name) { }
        public void Weep()
        {
            Console.WriteLine($"{name} is weeping");
        }
    }

}
