using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tortuga_DaniilArtyukhov.DB;

namespace Tortuga_DaniilArtyukhov.Classes
{
  public class Basket
    {
        public string FoodName { get; set; }
        public decimal Cost { get; set; }
    }

    public class ShoppingCart
    {
        private List<Food> _products = new List<Food>();
        public decimal TotalPrice { get; private set; }

        public void AddProduct(Food product)
        {
            _products.Add(product);
            RecalculateTotalPrice();
        }

        public void RemoveProduct(Food product)
        {
            _products.Remove(product);
            RecalculateTotalPrice();
        }

        private void RecalculateTotalPrice()
        {
            var totalPrice = 0m;
            foreach (var product in _products)
            {
                totalPrice += product.Cost;
            }
            TotalPrice = totalPrice;
        }
    }

}


    
