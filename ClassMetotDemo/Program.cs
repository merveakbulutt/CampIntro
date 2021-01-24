using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 12;
            customer1.Name = "Murat";
            customer1.Surname = "Kurt";

            Customer customer2 = new Customer();
            customer2.Id = 13;
            customer2.Name = "Tuğçe";
            customer2.Surname = "Karabulut";

            Customer customer3 = new Customer();
            customer3.Id = 14;
            customer3.Name = "Mustafa";
            customer3.Surname = "Yıldız";

            Console.WriteLine("MÜŞTERİ TAKİP");
            Customer[] customers = new Customer[] {customer1,customer2,customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.List(customers);
            customerManager.Delete(customer2);

        }
    }
}
