using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{

    public interface IPrintable
    {
        void Print();
    }

    public interface IScannable
    {
        void Scan();
    }

    public class PrinterScanner : IPrintable, IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printable");
        }

        public void Scan()
        {
            Console.WriteLine("Scannable");
        }
    }
}
