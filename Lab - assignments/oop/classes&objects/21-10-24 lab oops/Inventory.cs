using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class Inventory
    {
        public List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }

        public void DisplayItems()
        {
            foreach(Item item in items)
            {
                Console.WriteLine($"Name: {item.name}  Stock: {item.Stock}  Price: {item.Price}");
            }
        }
    }

    public class Item
    {
        public string name;
        
        private int stock;
        public int Stock
        {
            get { return stock; }
            set
            {
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

        private double price;
        public double Price
        {
            get { return price; }
            set { 
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Price cannot be zero or negative");
                }
            }
        }

        public Item(string Name, int stock, double price)
        {
            name = Name;
            Stock = stock;
            Price = price;
            
        }

        public void UpdateItem(string Name, int newStock, double newPrice)
        {
            name = Name;
            Stock = newStock;
            Price = newPrice;
        }
    }
}
