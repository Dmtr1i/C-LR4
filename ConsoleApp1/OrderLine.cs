using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OrderLine
    {
        private decimal number;
        private Product product;

        public OrderLine(int tempNumber, Product tempProduct)
        {
            number = tempNumber;
            product = tempProduct;
        }

        public OrderLine()
        {
            number = 0;
            product = null;
        }

        public decimal getNumber() { return number; }
        public Product getProduct() { return product; }

        public decimal getTotalPrice()
        {
            return number * product.getPrice();
        }

        public override string ToString()
        {
            return number + " * " + product.ToString() + "\n----------------------------\n" + getTotalPrice();
        }
    }
}
