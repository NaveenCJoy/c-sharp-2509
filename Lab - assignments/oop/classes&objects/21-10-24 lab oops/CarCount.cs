using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class CarCount
    {
        static int count;
        public string carName;
        public string carColor;

        static CarCount()
        {
            count = 0;
            Console.WriteLine("Count set to zero");
        }

        public CarCount(string CarName, string CarColor)
        {
            carName = CarName;
            carColor = CarColor;
            count += 1;
            Console.WriteLine($"New car created, count : {count}");
        }

        public void GetCount()
        {
            Console.WriteLine($"Count: {count}");
        }


    }
}
