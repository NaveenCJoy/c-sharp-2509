using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_24_morning
{
    public class Calculator
    {
        public int Number1;
        public int Number2;

        public Calculator(int num1, int num2)
        {
            Number1 = num1;
            Number2 = num2;
        }

        public void Print()
        {
            Console.WriteLine($"Number1 : {Number1}, Number2 : {Number2}");
        }

        public static Calculator operator +(Calculator calculator)
        {
            calculator.Number1 = calculator.Number1 * calculator.Number2;
            calculator.Number2 = calculator.Number1/calculator.Number2;
            calculator.Number1 = calculator.Number1/ calculator.Number2;
            return calculator;
        }

       
    }
}
