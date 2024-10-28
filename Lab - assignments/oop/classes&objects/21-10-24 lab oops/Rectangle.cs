using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Rectangle
    {
        public double area;
        public void CalculateArea(int side)
        {
            area = side * side;
            Console.WriteLine($"Area of square is {area}");
        }

        public void CalculateArea(int width, int height)
        {
            area = width * height;
            Console.WriteLine($"Area of rectangle is {area}");
        }
    }
}
