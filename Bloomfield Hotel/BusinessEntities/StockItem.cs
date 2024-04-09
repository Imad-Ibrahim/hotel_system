using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockItem : IStockItem
    {
        public int itemID { get; set; }
        public string description { get; set; }
        public string unit { get; set; }
        public int unitValue { get; set; }
        public double quantity { get; set; }
        public string supplier { get; set; }
        public double unitCost { get; set; }
        public int shelfLifeInDays { get; set; }
        public DateTime currentUseByDate { get; set; }

        public StockItem()
        {
            this.itemID = 0;
            this.description = "";
            this.unit = "";
            this.unitValue = 0;
            this.quantity = 0;
            this.supplier = "";
            this.unitCost = 0;
            this.shelfLifeInDays = 0;
            this.currentUseByDate = DateTime.Today;
        }
        public StockItem(int itemID, string description, string unit, int unitValue, double quantity, string supplier, double unitCost)
        {
            this.itemID = itemID;
            this.description = description;
            this.unit = unit;
            this.unitValue = unitValue;
            this.quantity = quantity;
            this.supplier = supplier;
            this.unitCost = unitCost;
            this.shelfLifeInDays = 0;
            this.currentUseByDate = DateTime.Today;
        }
        public StockItem(int itemID, string description, string unit, int unitValue, double quantity, string supplier, double unitCost, int shelfLifeInDays, DateTime currentUseByDate)
        {
            this.itemID = itemID;
            this.description = description;
            this.unit = unit;
            this.unitValue = unitValue;
            this.quantity = quantity;
            this.supplier = supplier;
            this.unitCost = unitCost;
            this.shelfLifeInDays = shelfLifeInDays;
            this.currentUseByDate = currentUseByDate;
        }
        public void UpdateUseByDate()
        {
            this.currentUseByDate = DateTime.Today.AddDays(this.shelfLifeInDays);
        }
    }
}
