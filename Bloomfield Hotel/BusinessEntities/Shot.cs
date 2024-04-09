using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Shot : SaleItem
    {
        public Shot(int itemID, string description, double price, string unit, int quantity) : base(itemID, description, price, unit, quantity)
        {
        }
    }
}
