using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_10_24_morning
{
    public class Emp
    {
        public void Add1()
        {
            Console.WriteLine("Add 1");
        }
    }

    static class Extension
    {
        public static void Add2(this Emp employee) {
            Console.WriteLine("Add 2 (extension)");
        }
    }
}
