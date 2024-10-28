using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_morning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("John Doe", 25, false, "Chennai", 5);
            Console.WriteLine(employee1.name);
            Console.WriteLine(employee1.age);
            Console.WriteLine(employee1.Salary());
            Console.WriteLine("Leave taken : "+employee1.Leave());
            Console.WriteLine("Expense : " + employee1.Expense());
            Console.WriteLine("------------------");
            Employee employee2 = new Employee("Jane Smith", 30, true, "Mumbai", 4);
            Console.WriteLine(employee2.name);
            Console.WriteLine(employee2.age);
            Console.WriteLine(employee2.Salary());
            Console.WriteLine("Leave taken : " + employee2.Leave());
            Console.WriteLine("Expense : " + employee2.Expense());
            Console.WriteLine("------------------");
            Employee employee3 = new Employee(employee2);
            Console.WriteLine(employee3.name);
            Console.ReadLine();
        }
    }
}
