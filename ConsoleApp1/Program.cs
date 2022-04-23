using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product one = new Product();
            one.setName("arisona");
            one.setPrice(310);
            Product two = new Product();
            two.setName("vedji");
            two.setPrice(260);
            Product three = new Product();
            three.setName("california");
            three.setPrice(295);
            Product four = new Product();
            four.setName("philadelphia");
            four.setPrice(370);
            Product five = new Product();
            five.setName("bonito");
            five.setPrice(350);
            ProductDatabase data = new ProductDatabase();
            data.addProduct(one);
            data.addProduct(two);
            data.addProduct(three);
            data.addProduct(four);
            data.addProduct(five);
            data.printDatabase();
            Customer cust = new Customer();
            Console.WriteLine("Введите имя покупателя: ");
            cust.setName(Console.ReadLine());
            Console.WriteLine("Введите адрес покупателя: ");
            cust.setAddres(Console.ReadLine());
            Console.WriteLine("Введите скидку покупателя: ");
            cust.setDiscount(Convert.ToDecimal(Console.ReadLine()));
            Order order = new Order(1, cust);
            order.addOrderLine(data.getProductByIndex(0), 2);
            order.addOrderLine(data.getProductByIndex(1), 5);
            order.addOrderLine(data.getProductByIndex(2), 1);
            order.addOrderLine(data.getProductByIndex(3), 1);
            order.addOrderLine(data.getProductByIndex(4), 9);
            Console.WriteLine(order.ToString());
        }
    }
}
