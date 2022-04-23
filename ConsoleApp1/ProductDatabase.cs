using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ProductDatabase
    {
        private List<Product> products;
        private int index = 0;

        public ProductDatabase()
        {
            products = new List<Product>();
        }

        public void addProduct(Product newProduct)
        {
            newProduct.setId("X" + index);
            index++;
            products.Add(newProduct);
        }

        public Product getProduct(string productId)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].getId() == productId)
                {
                    return products[i];
                }
            }
            return null;
        }

        public Product getProductByIndex(int index)
        {
            try
            {
                return products[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("error in getting product by index: " + e);
            }
            return null;
        }

        public void printDatabase()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].ToString());
            }
        }
    }
}
