using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SaleItemFactory
    {
        private static ISaleItem item = null;
        public static ISaleItem GetSaleItem(int itemID, string description, double price, string unit, int quantity)
        {
            switch (unit)
            {
                case "Bottle":
                    return new Bottle(itemID, description, price, unit, quantity);
                case "Pint":
                    return new Pint(itemID, description, price, unit, quantity);
                case "Shot":
                    return new Shot(itemID, description, price, unit, quantity);
                default:
                    return new SaleItem(itemID, description, price, unit, quantity);
            }
        }
        public static ISaleItem GetSaleItem(int itemID, string description, double price, string unit, int quantity, IRecipe recipe)
        {
            return new Meal(itemID, description, price, unit, quantity, recipe);
        }
        public static ISaleItem SellItem(int saleID, ISaleItem item, int quantity)
        {
            return new SoldItem(saleID, item.itemID, item.description, item.price, item.unit, quantity);
        }
        public static void SetSaleItem(ISaleItem anItem)
        {
            item = anItem;
        }
    }
}
