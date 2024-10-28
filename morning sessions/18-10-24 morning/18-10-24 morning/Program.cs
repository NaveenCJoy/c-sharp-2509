using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_24_morning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Naveen", "Kerala", 22);
            Employee employee2 = new Employee("John Doe", "Kerala", 25);
            employee1.Department = "finance";

            Console.WriteLine(employee1.name);
            Console.WriteLine(employee1.location);
            Console.WriteLine(employee1.age);
            Console.WriteLine("-----------------");
            Console.WriteLine(employee2.name);
            Console.WriteLine(employee2.location);
            Console.WriteLine(employee2.age);

            Console.WriteLine(employee1.Department);

            Console.WriteLine("--------static---------");
            Console.WriteLine(employee1.result());
            Console.WriteLine(employee2.result());
            Console.WriteLine("-----------------");
            Console.WriteLine(employee1.result2());
            Console.WriteLine(employee2.result2());
            Console.ReadLine();
        }
    }
}
