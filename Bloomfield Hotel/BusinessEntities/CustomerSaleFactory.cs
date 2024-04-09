using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CustomerSaleFactory
    {
        private static ICustomerSale sale = null;
        public static ICustomerSale GetCustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, IUser cashier)
        {
            return new CustomerSale(saleID, saleLineItems, guest, tableNumber, cashier);
        }
        public static ICustomerSale GetCustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, double total)
        {
            return new CustomerSale(saleID, saleLineItems, guest, tableNumber, total);
        }
        public static ICustomerSale GetCustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, double total, DateTime date, IUser cashier)
        {
            return new CustomerSale(saleID, saleLineItems, guest, tableNumber, total, date,  cashier);
        }
        public static void SetCustomerSale(ICustomerSale aSale)
        {
            sale = aSale;
        }
    }
}
