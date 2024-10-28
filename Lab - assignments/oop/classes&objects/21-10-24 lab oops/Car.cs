using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public double price;


        //constructor with make only
        public Car(string Make)
        {
            make = Make;
            model = "Unknown";
            year = 0;
            price = 0;
        }

        //constructor with make and model
        public Car(string Make, string Model) : this(Make)
        {
            model = Model;
        }

        //constructor with make, model and year
        public Car(string Make, string Model, int Year) : this(Make, Model)
        {
            year = Year;
        }


        //constructor with make, model, year and price
        public Car(string Make, string Model, int Year, int Price) : this(Make, Model, Year)
        {
            price = Price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Make: {make}  Model: {model}  Year: {year}  Price:{price}");
        }

    }
}
