using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CustomerSale : ICustomerSale
    {
        public int saleID { get; set; }
        public List<ISaleLineItem> saleLineItems { get; set; }
        public string guest { get; set; }
        public int tableNumber { get; set; }
        public double total { get; set; }
        public DateTime date { get; set; }
        public IUser cashier { get; set; }
        public CustomerSale()
        {
            this.saleID = 0;
            this.saleLineItems = new List<ISaleLineItem>();
            this.guest = "";
            this.tableNumber = 0;
            this.total = 0;
            this.date = DateTime.Now;
            this.cashier = new User();
        }
        public CustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, IUser cashier)
        {
            this.saleID = saleID;
            this.saleLineItems = saleLineItems;
            this.guest = guest;
            this.tableNumber = tableNumber;
            double total = 0;
            foreach (SaleLineItem sli in this.saleLineItems)
                total += sli.lineCost;
            this.total = total;
            this.date = DateTime.Now;
            this.cashier = cashier;
        }
        public CustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, double total)
        {
            this.saleID = saleID;
            this.saleLineItems = saleLineItems;
            this.guest = guest;
            this.tableNumber = tableNumber;
            this.total = total;
            this.date = DateTime.Now;
            this.cashier = new User();
        }
        public CustomerSale(int saleID, List<ISaleLineItem> saleLineItems, string guest, int tableNumber, double total, DateTime date, IUser cashier)
        {
            this.saleID = saleID;
            this.saleLineItems = saleLineItems;
            this.guest = guest;
            this.tableNumber = tableNumber;
            this.total = total;
            this.date = date;
            this.cashier = cashier;
        }
    }
}
