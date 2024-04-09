using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrder
    {
        int orderID { get; set; }
        DateTime date { get; set; }
        List<IOrderItem> orderItems { get; set; }
        string orderType { get; set; }
        string supplier { get; set; }
        bool acceptPartial { get; set; }
        bool received { get; set; }
        double total { get; set; }
    }
}
