using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    interface IDriveable
    {
        void Drive();
    }

    interface IRaceable : IDriveable
    {
        void Race();
    }


    internal class InterfaceInheritance : IDriveable, IRaceable
    {
        public void Drive() {
            Console.WriteLine("Drive");
        }
        public void Race()
        {
            Console.WriteLine("Race");
        }
    }
}
