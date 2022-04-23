using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer
    {
        private string name;
        private string address;
        private decimal discount;
        public Customer()
        {
            name = "null";
            address = "null";
            discount = 1;
        }

        public override string ToString()
        {
            return "Customer name: " + name + ", address: " + address + ", discount: " + discount + ";";
        }

        public void setName(string tempName) { name = tempName; }
        public void setAddres(string tempAddress) { address = tempAddress; }
        public void setDiscount(decimal tempDiscount) { discount = tempDiscount; }
        public string getName() { return name; }
        public string getAddress() { return address; }
        public decimal getDiscount() { return discount; }
    }
}
