using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HarambeExercise.Models;
using HarambeExercise.Repository;

namespace HarambeExercise.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {

        public ICustomerRepository CustomerRepo { get; set; }
        public IProductRepository ProductRepo { get; set; }
        public IBasketRepository BasketRepo { get; set; }
        public IBundleRepository BundleRepo { get; set; }

        // POST api/values
        [HttpPut("{customerId}")]
        public void addProductToBasket(int customerId, Product product)
        {
            Customer customer = CustomerRepo.Find(customerId);
            customer.Basket.Products.Add(product);
            List<Product> basketProducts = (System.Collections.Generic.List<HarambeExercise.Models.Product>)customer.Basket.Products;
        
            foreach (Bundle bundle in BundleRepo.GetAll()){
                List<Product> bundleProducts = (System.Collections.Generic.List<HarambeExercise.Models.Product>)bundle.Products;
                if (ContainsAllItems(basketProducts, bundleProducts)){
                    customer.Basket.Value = bundle.Value;
                }
            }

        }

        private bool ContainsAllItems(List<Product> customerProducts, List<Product> bundleProducts){
            return !bundleProducts.Except(customerProducts).Any();
        }


        [HttpGet("{id}", Name = "GetCustomer")]
        // GET: /<controller>/
        public IActionResult GetById(int id)
        {
            var customer = CustomerRepo.Find(id);

            if(customer == null)
            {
                return NotFound();
            }

            return new ObjectResult(customer); ;
        }

        [HttpGet]
        public IEnumerable<Product> GetPoducts()
        {
            return ProductRepo.GetAll();
        }

        [HttpGet("{categoryId}", Name = "GetProductsByCategory")]
        // GET: /<controller>/
        public IEnumerable<Product> GetAllByCategory(int categoryId)
        {
            return ProductRepo.GetAllByCategory(categoryId);
        }

        [HttpGet]
        public IEnumerable<Bundle> GetBundles()
        {
            return BundleRepo.GetAll();
        }

        [HttpGet]
        public double GetBasketCurrentValue(int customerId)
        {

            Customer customer = CustomerRepo.Find(customerId);
            return BasketRepo.GetBasketCurrentValue(customer.Basket.CartId);
        }



    }
}
