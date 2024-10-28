using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class EmployeeCopy
    {
        public int id;
        public string name;
        public int age;
        public string city;

        public EmployeeCopy(int Id, string Name, int Age, string City)
        {
            id = Id;
            name = Name;
            age = Age;            
            city = City;
        }

        //copy constructor
        public EmployeeCopy(EmployeeCopy newEmployee)
        {
            id = newEmployee.id;
            name = newEmployee.name;
            age = newEmployee.age;            
            city = newEmployee.city;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine($"ID: {id}  Name: {name}  Age: {age}  City: {city}");
        }

    }
}
