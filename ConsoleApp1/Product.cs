using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product
    {
        private string productId;
        private string name;
        private decimal price;

        public Product()
        {
            productId = "null";
            name = "null";
            price = 0;
        }

        public void setId(string id) { productId = id; }
        public void setName(string name) { this.name = name; }
        public void setPrice(decimal price) { this.price = price; }

        public string getId() { return this.productId; }
        public string getName() { return this.name; }
        public decimal getPrice() { return this.price; }

        public override string ToString()
        {
            return "Id: " + productId + ", Name: " + name + ", price: " + price;
        }
    }
}
