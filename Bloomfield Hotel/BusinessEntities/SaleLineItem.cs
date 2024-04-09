using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SaleLineItem : ISaleLineItem
    {
        public int saleID { get; set; }
        public ISaleItem item { get; set; }
        public bool cooked { get; set; }
        public double lineCost { get; set; }

        public SaleLineItem()
        {
            this.saleID = 0;
            this.item = null;
            this.cooked = false;
            this.lineCost = 0;
        }
        public SaleLineItem(int saleID, ISaleItem item)
        {
            this.saleID = saleID;
            this.item = item;
            this.cooked = false;
            this.lineCost = this.item.price * this.item.quantity;
        }
        public SaleLineItem(int saleID, ISaleItem item, bool cooked)
        {
            this.saleID = saleID;
            this.item = item;
            this.cooked = cooked;
            this.lineCost = this.item.price * this.item.quantity;
        }
        public void updateLineCost()
        {
            this.lineCost = this.item.price * this.item.quantity;
        }
        public void cook()
        {
            this.cooked = true;
        }
    }
}
