using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i=1; i<=11; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //print star pattern
            //Console.WriteLine("Enter no. of rows");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i=0; i<rows; i++)
            //{
            //    for (int j=0; j<=i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine("");
            //}

            //sum of 5 natural no
            //int sum = 0;
            //for (int i=1; i<=5; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //number pattern
            //int n = 1;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= 7; j++)
            //    {

            //    }
            //}
            int n = 1;
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(n + " ");
                    n += 1;
                }
                Console.WriteLine("");
            }


            //for (int i = 0; i < 30; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    if (i > 19)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i * 10);
            //}

            //for (int i = 10; i < 200; i++)
            //{
            //    if (i % 20 == 0)
            //    {
            //        continue;
            //    }
            //    if (i > 190)
            //    {
            //        break;
            //    }
            //    if (i%10 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());           
            //switch (number%2)
            //{
            //    case 0:
            //        Console.WriteLine($"{number} is an even number");
            //        break;
            //    case 1:
            //        Console.WriteLine($"{number} is an odd number");
            //        break;
            //    default:
            //        Console.WriteLine("error");
            //        break;
            //}

            //int[] num = {1, 2, 3, 4, 5};
            //for (int i=0; i<num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            Console.ReadLine();

        }
    }
}
