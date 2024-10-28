using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_10_24_lab_oops
{
    public class ShoppingCart
    {
        public List<ProductObject> productsList = new List<ProductObject>();
        public double totalPrice = 0;

        //add product to productslist
        public void AddProduct(ProductObject product)
        {
            productsList.Add(product);
        }
        

        public void DisplayAllProducts()
        {
            foreach(ProductObject p in productsList)
            {
                Console.WriteLine($"Name: {p.name}  Price: {p.price}  Quantity: {p.quantity}");
            }
        }

        public void CalculatePrice()
        {
            foreach (ProductObject p in productsList)
            {
                totalPrice += p.price;                
            }
            Console.WriteLine($"Total price is: {totalPrice}");

        }

        public class ProductObject
        {
            public string name;
            public double price;
            public int quantity;

            public ProductObject(string Name, double Price, int Quantity)
            {
                name = Name;
                price = Price;
                quantity = Quantity;
            }
        }
    }
}
