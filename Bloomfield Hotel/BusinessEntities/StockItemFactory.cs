using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class StockItemFactory
    {
        private static IStockItem item = null;
        public static IStockItem GetStockItem(int itemID, string description, string unit, int unitValue, double quantity, string supplier, double unitCost, string drinkType, string itemType, int shelfLifeInDays, DateTime currentUseByDate)
        {
            switch (itemType)
            {
                case "Food":
                    return new FoodItem(itemID, description, unit, unitValue, quantity, supplier, unitCost, shelfLifeInDays, currentUseByDate);
                case "Drink":
                    switch (drinkType)
                    {
                        case "Bottle":
                            return new StockBottle(itemID, description, unit, unitValue, quantity, supplier, unitCost);
                        case "Pint":
                            return new StockPint(itemID, description, unit, unitValue, quantity, supplier, unitCost);
                        case "Shot":
                            return new StockShot(itemID, description, unit, unitValue, quantity, supplier, unitCost);
                        default:
                            return new DrinkItem(itemID, description, unit, unitValue, quantity, supplier, unitCost);
                    }
                case "Cleaning":
                    return new CleaningItem(itemID, description, unit, unitValue, quantity, supplier, unitCost);
                default:
                    return new StockItem(itemID, description, unit, unitValue, quantity, supplier, unitCost);
            }
        }
        public static void SetStockItem(IStockItem anItem)
        {
            item = anItem;
        }
    }
}
