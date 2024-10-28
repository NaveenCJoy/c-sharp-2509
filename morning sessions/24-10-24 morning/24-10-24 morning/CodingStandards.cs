using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_24_morning
{
    public class Employee
    {
        public int lastName {  get; set; }

        public const string FIRST_NAME = "test";

        public void GetEmployeeDetails(int EmployeeId, string firstName)
        {
            Console.WriteLine("Do something...");
        }

        public interface ICalculation
        {
            void Add();
        }
    }
}
