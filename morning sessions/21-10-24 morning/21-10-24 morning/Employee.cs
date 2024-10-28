using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_morning
{
    internal class Employee
    {
        public string name;
        public int age;
        public bool fullTimeEmployee;
        public int salary;        
        public string location;
        public int leaveTaken;
        public int expense;


        //static constructor
        static Employee()
        {
            Console.WriteLine("Employee Details");
        }


        //parameterized constructor
        public Employee(string Name, int Age, bool fullTime, string Location, int Leave)
        {
            name = Name;
            age = Age;
            fullTimeEmployee = fullTime;
            location = Location;
            leaveTaken = Leave;
        }

        //calculate salary
        public int Salary()
        {
            if (fullTimeEmployee)
            {
                salary = 10000;
            }
            else
            {
                salary = 5000;
            }
            return salary;
        }

        //leave details
        public int Leave()
        {
            if (fullTimeEmployee)
            {
                return leaveTaken;
            }
            else
            {
                return -1;
            }
            
        }

        //expense details
        public int Expense()
        {
            if(location == "Chennai")
            {
                expense = 3000;
            }else if (location == "Mumbai")
            {
                expense = 2500;
            }
            return expense; 
        }

        //copy constructor
        public Employee(Employee emp)
        {
            name = emp.name;
            age = emp.age;
            fullTimeEmployee = emp.fullTimeEmployee;
            location = emp.location;
            leaveTaken = emp.leaveTaken;
        }
    }
}
