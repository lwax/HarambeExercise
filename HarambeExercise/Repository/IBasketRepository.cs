using HarambeExercise.Models;
using System;
using System.Collections.Generic;

namespace HarambeExercise.Repository
{
    public interface IBasketRepository
    {
        void AddProductToBasket(int cartId, Product product);
        void Add(Basket basket);
        IEnumerable<Basket> GetAll();
        Basket Find(int Id);
        double GetBasketCurrentValue(int id);
        void Remove(int Id);
        void Update(Basket basket);
    }
}
