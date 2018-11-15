using System;
using System.Collections.Generic;

namespace HarambeExercise.Models
{
    public class Bundle
    {
        public int BundleId { get; set; }
        public string BundleName { get; set; }
        public ICollection<Product> Products { get; set; }
        public double Value { get; set; }
        public double DiscountValue { get; set; }
    }
}
