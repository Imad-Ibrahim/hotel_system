using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Meal : SaleItem
    {
        public IRecipe recipe { get; set; }
        public Meal(int itemID, string description, double price, string unit, int quantity, IRecipe recipe) : base(itemID, description, price, unit, quantity)
        {
            this.recipe = recipe;
        }
    }
}
