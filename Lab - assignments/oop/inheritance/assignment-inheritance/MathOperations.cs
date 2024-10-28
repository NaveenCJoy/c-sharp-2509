using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{
    sealed class MathOperations
    {
        public void Add()
        {
            Console.WriteLine("Sealed");
        }
    }

    //public class Test : MathOperations
    //{
    //    public void Sub()
    //    {
    //        Console.WriteLine("Sealed");
    //    }
    //}
}
