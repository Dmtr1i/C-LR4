using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Order
    {
        private int number;
        private Customer customer;
        private decimal discount;
        private List<OrderLine> line;

        public Order(int tempNumber, Customer tempCustomer)
        {
            number = tempNumber;
            customer = tempCustomer;
            discount = customer.getDiscount();
            line = new List<OrderLine>();
        }

        public void addOrderLine(Product product, int quantity)
        {
            OrderLine tempLine = new OrderLine(quantity, product);
            line.Add(tempLine);
        }

        public  decimal orderTotal()
        {
            decimal tempPrice = 0;
            for (int i = 0; i < line.Count; i++) tempPrice += line[i].getTotalPrice();
            return tempPrice * customer.getDiscount();
        }

        public override string ToString()
        {
            string tempList = "";
            for (int i = 0; i < line.Count; i++) tempList += line[i].ToString() + "\n";
            return customer.ToString() + "\nComplete order №" + number + ":\n" +
            tempList + "Total price: " + orderTotal();
        }
    }
}
