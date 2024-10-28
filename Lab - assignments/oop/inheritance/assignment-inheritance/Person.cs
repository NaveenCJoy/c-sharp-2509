using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    public class Student : Person
    {
        public double grade;

        public Student(string name, int age, double grade) : base(name, age)
        {
            this.grade = grade;
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"Name: {name}  Age: {age}  Grade: {grade}");
        }
    }
}
