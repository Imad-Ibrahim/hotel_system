using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class GuestFactory
    {
        private static IGuest guest = null;

        public static IGuest GetGuest(int guestID, string name, string address, string phoneNumber, string email, bool marketingConsent, bool saveCustomerDetails, ICreditCard creditCard)
        {
            if (guest != null)  // ie is Factory is primed with an object. 
                return guest;
            else
                return new Guest(guestID, name, address, phoneNumber, email, marketingConsent, saveCustomerDetails, creditCard);
        }
        public static void SetGuest(IGuest aGuest)
        {
            guest = aGuest;
        }
    }
}
