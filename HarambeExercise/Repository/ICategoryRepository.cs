using HarambeExercise.Models;
using System;
using System.Collections.Generic;

namespace HarambeExercise.Repository
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        IEnumerable<Category> GetAll();
        Category Find(int Id);
        void Remove(int Id);
        void Update(Category category);
    }
}
