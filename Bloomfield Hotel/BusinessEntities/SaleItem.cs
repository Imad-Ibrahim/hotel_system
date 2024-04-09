using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SaleItem : ISaleItem
    {
        public int itemID { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string unit { get; set; }
        public int quantity { get; set; }
        public SaleItem()
        {
            this.itemID = 0;
            this.description = "";
            this.price = 0;
            this.unit = "";
            this.quantity = 0;
        }
        public SaleItem(int itemID, string description, double price, string unit, int quantity)
        {
            this.itemID = itemID;
            this.description = description;
            this.price = price;
            this.unit = unit;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return this.itemID + " " + this.description + " " + this.price + " " + this.unit + " " + this.quantity;
        }
    }
}
