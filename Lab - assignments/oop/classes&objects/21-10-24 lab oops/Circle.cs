using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    internal class Circle
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("radius cannot be negative");
                }
                else
                {
                    radius = value;
                }
            }


        }

        //public Circle(int Radius)
        //{
        //    radius = Radius;
        //}
    }
}
