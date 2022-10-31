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
        private List<CartLine> lineCollection = new List<CartLine>();

        public void AddItem(Food food, int quantity)
        {
            CartLine line = lineCollection
              .Where(p => p.Food.ID == food.ID)
              .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Food = food,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Food food)
        {
            lineCollection.RemoveAll(l => l.Food.ID == food.ID);
        }

        public decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Food.Cost * e.Quantity);
        }

        public void Clear()
        {
            lineCollection.Clear();
        }

        public IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Food Food { get; set; }
        public int Quantity { get; set; }
    }
}


    
