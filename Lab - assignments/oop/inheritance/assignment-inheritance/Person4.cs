using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    public class Person4
    {
        public string Name;

    }

    public class Student4 : Person4
    {
        public new string Name;

        public void DisplayName()
        {
            Console.WriteLine($"Person name: {base.Name}");
            Console.WriteLine($"Student name: {Name}");
        }
    }
}
