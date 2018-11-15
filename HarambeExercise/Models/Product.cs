using System;
namespace HarambeExercise.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Category Category { get; set; } 
        public double Value { get; set; }
    }
}
