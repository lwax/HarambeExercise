using System;
using System.Collections.Generic;
using System.Linq;
using HarambeExercise.Models;

namespace HarambeExercise.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        static List<Customer> CustomersList = new List<Customer>();

        public void Add(Customer customer)
        {
            CustomersList.Add(customer);
        }

        public Customer Find(int Id)
        {
            return CustomersList
                .Where(customer => customer.CustomerId == (Id))
                .SingleOrDefault();
        }

        public IEnumerable<Customer> GetAll()
        {
            return CustomersList;
        }

        public void Remove(int Id)
        {
            var itemToRemove = CustomersList.SingleOrDefault(customer => customer.CustomerId == Id);
            if (itemToRemove != null)
                CustomersList.Remove(itemToRemove);
        }

        public void Update(Customer customer)
        {
            var itemToUpdate = CustomersList.SingleOrDefault(cust => cust.CustomerId == customer.CustomerId);
            if (itemToUpdate != null)
            {
                itemToUpdate.CustomerFirstName = customer.CustomerFirstName;
                itemToUpdate.CustomerLastName = customer.CustomerLastName;
                itemToUpdate.CustomerEmail = customer.CustomerEmail;
                itemToUpdate.CustomerPhoneNumber = customer.CustomerPhoneNumber;
                itemToUpdate.CustomerAddress = customer.CustomerAddress;
            }
        }
    }
}
