using HarambeExercise.Models;
using System;
using System.Collections.Generic;

namespace HarambeExercise.Repository
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        IEnumerable<Customer> GetAll();
        Customer Find(int Id);
        void Remove(int Id);
        void Update(Customer customer);
    }
}
