using System;
using System.Collections.Generic;

namespace HarambeExercise.Models
{
    public class Basket
    {

        public int CartId { get; set; }
        public string CartName { get; set; }
        public ICollection<Product> Products { get; set; } 
        public Double Value { get; set; }
    }
}
