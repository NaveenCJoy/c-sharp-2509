using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Product2
    {
        public string name;
        public double price;
        public string category;

        //constructor that initialized all three properties
        public Product2(string Name, double Price, string Category)
        {
            name = Name;
            price = Price;
            category = Category;
        }

        //constructor with default values
        public Product2()
        {
            name = "Default name";
            price = 0.0;
            category = "Default category";
        }

        //static method
        public static Product2 CreateProduct(string Name, double Price, string Category)
        {
            return new Product2(Name, Price, Category);
        }

       

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {name}  Price: {price}  Category: {category}");
        }

    }
}
