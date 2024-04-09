using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ISaleLineItem
    {
        int saleID { get; set; }
        ISaleItem item { get; set; }
        bool cooked { get; set; }
        double lineCost { get; set; }
        void updateLineCost();
        void cook();
    }
}
