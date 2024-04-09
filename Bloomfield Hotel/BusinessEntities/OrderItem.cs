using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OrderItem : IOrderItem
    {
        public int lineID { get; set; }
        public int orderID { get; set; }
        public IStockItem item { get; set; }
        public int quantity { get; set; }
        public double lineCost { get; set; }
        public OrderItem()
        {
            this.lineID = 0;
            this.orderID = 0;
            this.item = null;
            this.quantity = 0;
            this.lineCost = 0;
        }
        public OrderItem(int lineID, int orderID, IStockItem item, int quantity)
        {
            this.lineID = lineID;
            this.orderID = orderID;
            this.item = item;
            this.quantity = quantity;
            this.lineCost = item.unitCost * quantity;
        }
        public override string ToString()
        {
            string result = "";
            result += lineID + " " + orderID + " " + item.description + " " + quantity + " " + lineCost;
            return result;
        }
    }
}
