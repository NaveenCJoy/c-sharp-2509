using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Print
    {
        public void PrintInput(int input)
        {
            Console.WriteLine($"Integer: {input}");
        }

        public void PrintInput(string input)
        {
            Console.WriteLine($"String: {input}");
        }

        public void PrintInput(int[] input)
        {
            Console.Write("Array:");
            foreach(int item in input)
            {
                Console.Write($" {item} ");
            }            
        }
    }
}
