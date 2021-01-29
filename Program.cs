using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Demo from Armağan Bice 29.01.2021");
            CustomerManager customerManager = new CustomerManager();
            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Armağan";
            customer1.LastName = "Bice";
            customers.Add(customer1);
            customerManager.Add(customer1);

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customers.Add(customer2);
            customerManager.Add(customer2);

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Seda";
            customer3.LastName = "Bakan";
            customers.Add(customer3);
            customerManager.Add(customer3);

            Console.WriteLine("CustomerList - All ");
            customerManager.CustomerList(customers);

            customerManager.Delete(customer3);
            customers.Remove(customer3);
            Console.WriteLine("CustomerList - after delete");

            customerManager.CustomerList(customers);

            Console.ReadLine();
        }
    }
}
