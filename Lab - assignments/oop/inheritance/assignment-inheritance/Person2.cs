using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Person2
    {
        public Person2(string name)
        {
            Console.WriteLine($"Person name : {name}");
        }
    }

    public class Employee2 : Person2
    {
        public Employee2(string name, int id) : base(name){
            Console.WriteLine($"Employee Name : {name}   ID : {id}");
        }
    }
}
