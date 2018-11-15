using System;
using System.Collections.Generic;
using System.Linq;
using HarambeExercise.Models;

namespace HarambeExercise.Repository
{
    public class BundleRepository : IBundleRepository
    {

        static List<Bundle> BundleList = new List<Bundle>();

        public void Add(Bundle bundle)
        {
            BundleList.Add(bundle);
        }

        public Bundle Find(int Id)
        {

            return BundleList
                    .SingleOrDefault(bundle => bundle.BundleId == (Id));
        }

        public IEnumerable<Bundle> GetAll()
        {
            return BundleList;
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Bundle bundle)
        {
            throw new NotImplementedException();
        }
    }
}
