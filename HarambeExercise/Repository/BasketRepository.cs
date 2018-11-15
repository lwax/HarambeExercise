using System;
using System.Collections.Generic;
using System.Linq;
using HarambeExercise.Models;

namespace HarambeExercise.Repository
{
    public class BasketRepository : IBasketRepository
    {

        static List<Basket> BasketList = new List<Basket>();


        public void AddProductToBasket(int cartId, Product product)
        {
            Basket basket = Find(cartId);

            basket.Products.Add(product);   
        }

        public void Add(Basket basket)
        {
            BasketList.Add(basket);
        }


        public Basket Find(int Id)
        {

            return BasketList
                .SingleOrDefault(basket => basket.CartId == (Id));
        }

        public IEnumerable<Basket> GetAll()
        {
            return BasketList;
        }

        public double GetBasketCurrentValue(int id)
        {
            Basket basket = Find(id);
            double currentValue = 0;

            foreach(Product product in basket.Products){
                currentValue += product.Value;
            }

            return currentValue;
        }

        public void Remove(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Basket basket)
        {
            throw new NotImplementedException();
        }
    }
}
