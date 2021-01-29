using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added " + customer.FirstName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Updated " + customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted " + customer.FirstName);
        }

        public void CustomerList(List<Customer> customers)
        {
  
            foreach(Customer customer in customers)
            {
                Console.WriteLine("Id :" + customer.Id);
                Console.WriteLine("First Name :" + customer.FirstName);
                Console.WriteLine("Last Name :" + customer.LastName);
            }
        }

    }
}
