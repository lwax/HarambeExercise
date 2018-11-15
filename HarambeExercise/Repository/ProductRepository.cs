using System;
using System.Collections.Generic;
using System.Linq;
using HarambeExercise.Models;

namespace HarambeExercise.Repository
{
    public class ProductRepository : IProductRepository
    {

        static List<Product> ProductList = new List<Product>();

        public void Add(Product product)
        {
            ProductList.Add(product);
        }

        public Product Find(int Id)
        {
            return ProductList
                   .SingleOrDefault(product => product.ProductId == (Id));
        }

        public IEnumerable<Product> GetAll()
        {
            return ProductList;
        }

        public IEnumerable<Product> GetAllByCategory(int Id)
        {
            List<Product> products = new List<Product>();
            foreach (Product product in ProductList){
                if(product.Category.CategoryId == Id){
                    products.Add(product);
                }
            }

            return products;
        }

        public void Remove(int Id)
        {
            var itemToRemove = ProductList.SingleOrDefault(product => product.ProductId == Id);
            if (itemToRemove != null)
                ProductList.Remove(itemToRemove);
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
