using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _24_10_24_morning
{
    public abstract class A
    {
        public int a;
        public int b;

        public abstract void Add();

        public void Sub()
        {
            Console.WriteLine("Sub invoked in class A");
        }
        

    }

    interface IB
    {
        void Divide();
    }
    interface IC
    {
        void Multiply();
    }

    public class D : A
    {
        public override void Add()
        {
            Console.WriteLine("Add invoked in abstract class C");
        }
    }

    public class E : IB, IC
    {
        public void Divide()
        {
            Console.WriteLine("Divide invoked in E");
        }

        public void Multiply()
        {
            Console.WriteLine("Multiply invoked in E");
        }
    }
}
