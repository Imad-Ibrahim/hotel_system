using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ISaleItem
    {
        int itemID { get; set; }
        string description { get; set; }
        double price { get; set; }
        string unit { get; set; }
        int quantity { get; set; }
    }
}
