using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_24_morning
{
    public class Employee
    {
        public string name;
        public int age;
        public string location;

        public Employee(string Name, int Age, string Location)
        {
            name = Name;
            age = Age;
            location = Location;
        }
    }

    public class EmployeeList
    {
        public List<Employee> employeesList = new List<Employee>();

        public void AddEmployee(Employee emp)
        {
            employeesList.Add(emp);
        }

        public void DisplayAllEmployees()
        {
            foreach (Employee emp in employeesList)
            {
                Console.WriteLine($"Name: {emp.name}  Age: {emp.age}  Location: {emp.location}");
            }
        }
    }
}
