using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockPint : DrinkItem
    {
        public StockPint(int itemID, string description, string unit, int unitValue, double quantity, string supplier, double unitCost) : base(itemID, description, unit, unitValue, quantity, supplier, unitCost)
        {
        }
    }
}
