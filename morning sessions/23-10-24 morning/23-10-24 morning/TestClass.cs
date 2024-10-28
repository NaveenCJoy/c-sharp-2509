using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_10_24_morning
{
    public class TestClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(double a, double b)
        {
            return (int)(a + b);
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        
    }
}
