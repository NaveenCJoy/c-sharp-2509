using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _22_10_24_morning
{
    //public class Vehicle
    //{
    //    public void GetVehicleColor()
    //    {
    //        Console.WriteLine("blue");
            
    //    }

    //    public void GetVehicleRegistration()
    //    {
    //        Console.WriteLine("kerala");
    //    }
        
    //}



    //public class FourWheeler : Vehicle
    //{
    //    public void GetWheelsCount()
    //    {
    //        Console.WriteLine(4);
    //    }
    //}

    //public class Suv : FourWheeler
    //{        
              

    //    public void GetVehicleName()
    //    {
    //        Console.WriteLine("It is an SUV");
    //    }
    //}

    //public class Sedan : FourWheeler
    //{
    //    public void GetVehicleName()
    //    {
    //        Console.WriteLine("It is a Sedan");
    //    }
    //}

    //public class Hatchback : FourWheeler
    //{
    //    public void GetVehicleName()
    //    {
    //        Console.WriteLine("It is a Hatchback");
    //    }
    //}

    public interface A
    {
        int add(int a, int b);
    }

    interface B
    {
        int Sub(int a, int b);
    }

    class C : A, B
    {
        public int add(int a, int b)
        {
            return a+b;
        }

        public int Sub(int a, int b)
        {
            return a-b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }

}
