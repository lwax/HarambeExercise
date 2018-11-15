using System;
using System.Collections.Generic;
using System.Linq;
using HarambeExercise.Models;

namespace HarambeExercise.Repository
{
    public class CategoryRepository : ICategoryRepository
    {

        static List<Category> CategoryList = new List<Category>();

        public void Add(Category category)
        {
            CategoryList.Add(category);
        }

        public Category Find(int Id)
        {

            return CategoryList
                .SingleOrDefault(category => category.CategoryId == (Id));
        }

        public IEnumerable<Category> GetAll()
        {
            return CategoryList;
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
