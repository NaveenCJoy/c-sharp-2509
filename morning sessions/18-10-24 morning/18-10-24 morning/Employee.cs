using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_24_morning
{
    public class Employee
    {
        public string name;
        public string location;
        public int age;

        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        //default constructor
        public Employee(string employeeName, string employeeLocation, int employeeAge)
        {
            name = employeeName;
            location = employeeLocation;
            age = employeeAge;
            
        }       

        static int a = 1;
        public int b = 5;

        public int result2()
        {
            b = b + 5;
            return b;
        }
        public int result()
        {
            a = a + 1;
            return a;
        }
    }

    
}
