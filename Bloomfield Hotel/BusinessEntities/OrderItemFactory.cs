using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OrderItemFactory
    {
        private static IOrderItem item = null;
        public static IOrderItem GetOrderItem(int lineID, int orderId, IStockItem item, int quantity)
        {
            return new OrderItem(lineID, orderId, item, quantity);
        }
        public static void SetOrderItem(IOrderItem anItem)
        {
            item = anItem;
        }
    }
}
