using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Time
    {

        public int hour;
        public int minute;
        public void SetTime(int hours, int minutes)
        {
            hour = hours;
            minute = minutes;
            Console.WriteLine($"Time is {hour} H : {minute} M");
        }

        public void  SetTime(int seconds)
        {
            hour = seconds / 3600;
            minute = (seconds%3600) /60;
            Console.WriteLine($"Time is {hour} H : {minute} M");
        }
    }
}
