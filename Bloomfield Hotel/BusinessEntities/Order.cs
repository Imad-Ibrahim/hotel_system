using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order : IOrder
    {
        public int orderID { get; set; }
        public DateTime date { get; set; }
        public List<IOrderItem> orderItems { get; set; }
        public string orderType { get; set; }
        public string supplier { get; set; }
        public bool acceptPartial { get; set; }
        public bool received { get; set; }
        public double total { get; set; }
        public Order() { }
        public Order(int orderID, DateTime date, string orderType, string supplier, bool acceptPartial)
        {
            this.orderID = orderID;
            this.date = date;
            this.orderType = orderType;
            this.supplier = supplier;
            this.acceptPartial = acceptPartial;
            this.received = false;
        }
        public Order(int orderID, DateTime date, List<IOrderItem> orderItems, string orderType, string supplier, bool acceptPartial)
        {
            this.orderID = orderID;
            this.date = date;
            this.orderItems = orderItems;
            this.orderType = orderType;
            this.supplier = supplier;
            this.acceptPartial = acceptPartial;
            this.received = false;
            CalculateTotal();
        }
        public Order(int orderID, DateTime date, List<IOrderItem> orderItems, string orderType, string supplier, bool acceptPartial, bool received)
        {
            this.orderID = orderID;
            this.date = date;
            this.orderItems = orderItems;
            this.orderType = orderType;
            this.supplier = supplier;
            this.acceptPartial = acceptPartial;
            this.received = received;
            CalculateTotal();
        }
        public void CalculateTotal()
        {
            double total = 0;
            foreach (OrderItem o in orderItems)
                total += o.lineCost;
            this.total = total;
        }
    }
}
