using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SoldItem : SaleItem
    {
        public int saleID { get; set; }
        public SoldItem(int saleID, int itemID, string description, double price, string unit, int quantity) : base(itemID, description, price, unit, quantity)
        { this.saleID = saleID; }
    }
}
