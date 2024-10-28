using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Product
    {
        public string name;
        public double price;
        public double discount;

        //constructor with name only
        public Product(string Name)
        {
            name = Name;
            price = 0;
            discount = 0;
        }

        //constructor with name and price
        public Product(string Name, double Price) : this(Name)
        {
            price = Price;
        }

        //constructor with name, price and discount
        public Product(string Name, double Price, double Discount) : this(Name, Price)
        {
            discount = Discount;
        }

        public void CalculateFinalPrice()
        {
            if (discount != 0)
            {
                double discountAmount = (price / 100) * discount;
                double finalPrice = price - discountAmount;
                Console.WriteLine($"The final price is {finalPrice}");
            }
            else if (price == 0)
            {
                Console.WriteLine("Price not available");
            }
            else
            {
                Console.WriteLine($"No discount. The final price is {price}");
            }            
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}  Price: {price}  Discount: {discount}");
            CalculateFinalPrice();
        }
    }
}
