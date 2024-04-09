using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICustomerSale
    {
        int saleID { get; set; }
        List<ISaleLineItem> saleLineItems { get; set; }
        string guest { get; set; }
        int tableNumber { get; set; }
        double total { get; set; }
        DateTime date { get; set; }
        IUser cashier { get; set; }
    }
}
