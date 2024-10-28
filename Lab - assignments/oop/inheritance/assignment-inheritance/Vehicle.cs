using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_inheritance
{

    public interface IMovable
    {
        void MoveFunc();
    }

    public interface IRechargeable
    {
        void RechargeFunc();
    }

    public class Vehicle : IMovable
    {
        public string vehicleName;

        public Vehicle(string name)
        {
            vehicleName = name;
        }
        public void MoveFunc()
        {
            Console.WriteLine($"{vehicleName} is movable");
        }

    }

    public class ElectricCar : Vehicle, IRechargeable
    {
        public ElectricCar(string name) : base(name) { }
        
        public void RechargeFunc()
        {
            Console.WriteLine($"{vehicleName} is rechargeable");
        }

    }
}
