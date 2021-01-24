using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("added customer :"+customer.Id+" "+customer.Name+" "+customer.Surname);
        }

       public void List(Customer[] customers)
        {
            foreach(var customer in customers)
            {
                Console.WriteLine(customer.Id+" "+customer.Name+" "+customer.Surname);
            }
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("deleted customer :"+customer.Id + " " + customer.Name + " " + customer.Surname);
        }
    }
}
