using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class FoodItem : StockItem
    {
        public FoodItem() : base()
        {
        }
        public FoodItem(int itemID, string description, string unit, int unitValue, double quantity, string supplier, double unitCost, int shelfLifeInDays, DateTime currentUseByDate) : base(itemID, description, unit, unitValue, quantity, supplier, unitCost, shelfLifeInDays, currentUseByDate)
        {
        }
    }
}
