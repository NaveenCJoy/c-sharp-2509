using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class MathOperations
    {
        static double pi;

        static MathOperations()
        {
            pi = 3.14;
            Console.WriteLine($"Value of pi set to {pi}");
        }
    }
}
