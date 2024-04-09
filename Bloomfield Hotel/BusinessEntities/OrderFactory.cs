using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OrderFactory
    {
        private static IOrder order = null;
        public static IOrder GetOrder(int orderID, DateTime date, List<IOrderItem> orderItems, string orderType, string supplier, bool acceptPartial)
        {
            return new Order(orderID, date, orderItems, orderType, supplier, acceptPartial);
        }
        public static IOrder GetOrder(int orderID, DateTime date, List<IOrderItem> orderItems, string orderType, string supplier, bool acceptPartial, bool received)
        {
            return new Order(orderID, date, orderItems, orderType, supplier, acceptPartial, received);
        }
        public static void SetOrder(IOrder anOrder)
        {
            order = anOrder;
        }
    }
}
