using HarambeExercise.Models;
using System.Collections.Generic;
namespace HarambeExercise.Repository
{
    public interface IProductRepository
    {
        void Add(Product product);
        IEnumerable<Product> GetAll();
        Product Find(int Id);
        IEnumerable<Product> GetAllByCategory(int Id);
        void Remove(int Id);
        void Update(Product product);
    }
}
