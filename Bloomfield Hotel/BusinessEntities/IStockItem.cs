using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStockItem
    {
        int itemID { get; set; }
        string description { get; set; }
        string unit { get; set; }
        int unitValue { get; set; }
        double quantity { get; set; }
        string supplier { get; set; }
        double unitCost { get; set; }
        int shelfLifeInDays { get; set; }
        DateTime currentUseByDate { get; set; }
        void UpdateUseByDate();
    }
}
