using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Ecommerce
    {
        public List<Products> productsList = new List<Products>();

        public void AddProduct(Products product)
        {
            productsList.Add(product);
        }
        public void RemoveProduct(Products product)
        {
            productsList.Remove(product);
        }

        public void DisplayAllProducts()
        {
            foreach (Products item in productsList)
            {
                Console.WriteLine($"Name: {item.name}  Stock: {item.Stock}  Price: {item.Price}");
            }
        }
    }

    public class Products
    {
        public string name;
        private double price;
        public double Price
        {
            get { return price; }
            set {
                if (value > 0)
                {
                    price = value;
                }
                else {
                    throw new ArgumentException("Price must be greater than zero");
                }
            }
        }

        private int stock;
        public int Stock
        {
            get { return stock; }
            set {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new ArgumentException("Stock cannot be negative");
                }
            }
        }

        public Products(string Name, int stock, double price)
        {
            name = Name;
            Stock = stock;
            Price = price;
        }

    }

    public class Orders
    {
        public Orders(Products order, int number)
        {
            order.Stock -= number;
            Console.WriteLine($"{number} order of {order.name} completed. Current stock: {order.Stock}");
        }
    }
}
