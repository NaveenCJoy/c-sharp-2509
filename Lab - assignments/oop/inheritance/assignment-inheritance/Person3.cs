using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Person3
    {
        public string Name;
        public int Age;

        public Person3(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}  Age: {Age}");
        }

    }

    public class Employee3 : Person3
    {
        public int JobId;

        public Employee3(string name, int age, int jobId) : base(name, age)
        {
            JobId = jobId;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Job ID: {JobId}");

        }
    }
}
