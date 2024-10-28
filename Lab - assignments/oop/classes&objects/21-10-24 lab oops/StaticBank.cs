using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class StaticBank
    {
        static double interest;
        public double balance;

        static StaticBank()
        {
            interest = 7.2;
            Console.WriteLine($"Interest set to {interest}");
        }

        public StaticBank(int Balance)
        {
            balance = Balance;
            Console.WriteLine($"Balance set to {balance}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Balance: {balance}, Interest rate: {interest}%");
        }
    }
}
