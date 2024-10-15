using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter A");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter B");
            string num2 = Console.ReadLine();
            Console.WriteLine("Enter C");
            string num3 = Console.ReadLine();

            int a = Convert.ToInt32(num1);
            int b = Convert.ToInt32(num2);
            int c = Convert.ToInt32(num3);
            int largest = a;
            int secLargest = b;

            if (b > a)
            {
                largest = b;
                secLargest = a;             
            }
            if (c > secLargest && c < largest)
            {
                secLargest = c;
            }
            else if (c > largest) {
                secLargest = largest;
                largest = c;
            }
            else if (a==b || a==c || b == c)
            {
                Console.WriteLine("Numbers are not distinct");
            }
            else
            {
                Console.WriteLine(secLargest + " is the second largest number");
            }
            Console.ReadLine();


            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a + ": A is greater");
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine(b + ": B is greater");
            //}
            //else if (c > a && c > b)
            //{
            //    Console.WriteLine(c + ": C is greater");
            //}            
            //Console.ReadLine();




            //Console.WriteLine("hello");
            //int a = 1;
            //int b = 3;
            //string c = "5";
            //int d = Convert.ToInt32(a);
            //if (a == b)
            //{
            //    Console.WriteLine(3 * (a + b));
            //}
            //if(a != b)
            //{
            //    Console.WriteLine(a + b);
            //}
            //Console.ReadLine();
        }
    }
}
