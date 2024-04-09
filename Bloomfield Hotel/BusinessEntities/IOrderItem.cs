using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrderItem
    {
        int lineID { get; set; }
        int orderID { get; set; }
        IStockItem item { get; set; }
        int quantity { get; set; }
        double lineCost { get; set; }
    }
}
