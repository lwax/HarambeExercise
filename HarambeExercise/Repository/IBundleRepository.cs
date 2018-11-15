using System;
using HarambeExercise.Models;
using System.Collections.Generic;
namespace HarambeExercise.Repository
{
    public interface IBundleRepository
    {
        void Add(Bundle bundle);
        IEnumerable<Bundle> GetAll();
        Bundle Find(int Id);
        void Remove(int Id);
        void Update(Bundle bundle);
    }
}
