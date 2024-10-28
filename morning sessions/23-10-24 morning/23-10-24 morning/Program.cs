using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_24_morning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //TestClass test1 = new TestClass();

            //Console.WriteLine(test1.Add(1, 2));
            //Console.WriteLine(test1.Add(1.5,8.9));
            //Console.WriteLine(test1.Add(3, 4, 5));



            //Calculator calculator1 = new Calculator(5,10);

            //Calculator calculator2 = +calculator1;

            //calculator2.Print();

            //Console.ReadLine();


            EmployeeList employeesList = new EmployeeList();

            Employee employee1 = new Employee("name1", 30, "Chennai");
            Employee employee2 = new Employee("name2", 32, "Mumbai");
            Employee employee3 = new Employee("name3", 33, "Kochi");
            Employee employee4 = new Employee("name4", 41, "Kolkate");
            Employee employee5 = new Employee("name5", 53, "Chennai");

            employeesList.AddEmployee(employee1);
            employeesList.AddEmployee(employee2);
            employeesList.AddEmployee(employee3);
            employeesList.AddEmployee(employee4);
            employeesList.AddEmployee(employee5);

            employeesList.DisplayAllEmployees();

            Console.ReadLine();

        }
    }
}
