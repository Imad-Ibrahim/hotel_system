using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IGuest
    {
        int GuestID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        bool MarketingConsent { get; set; }
        bool SaveCustomerDetails { get; set; }
        ICreditCard CreditCard { get; set; }
    }
}
