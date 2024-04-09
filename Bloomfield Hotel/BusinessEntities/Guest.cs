using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Guest : IGuest
    {
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool MarketingConsent { get; set; }
        public bool SaveCustomerDetails { get; set; }
        public ICreditCard CreditCard { get; set; }
        public Guest() { }

        public Guest(int guestID, string name, string address, string phoneNumber, string email, bool marketingConsent, bool saveCustomerDetails, ICreditCard creditCard)
        {
            this.GuestID = guestID;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.MarketingConsent = marketingConsent;
            this.SaveCustomerDetails = saveCustomerDetails;
            this.CreditCard = creditCard;
        }
    }
}
