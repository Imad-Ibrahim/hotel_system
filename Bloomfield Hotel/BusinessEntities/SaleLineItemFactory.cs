using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class SaleLineItemFactory
    {
        private static ISaleLineItem sli = null;
        public static ISaleLineItem GetSaleLineItem(int saleID, ISaleItem item, int quantity)
        {
            ISaleItem s = SaleItemFactory.SellItem(saleID, item, quantity);
            return new SaleLineItem(saleID, s);
        }
        public static ISaleLineItem GetSaleLineItem(int saleID, ISaleItem item, int quantity, bool cooked)
        {
            ISaleItem s = SaleItemFactory.SellItem(saleID, item, quantity);
            return new SaleLineItem(saleID, s, cooked);
        }
        public static void SetSaleLineItem(ISaleLineItem anItem)
        {
            sli = anItem;
        }
    }
}
