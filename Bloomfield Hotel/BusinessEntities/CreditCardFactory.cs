using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CreditCardFactory
    {
        private static ICreditCard creditCard = null;

        public static ICreditCard GetCreditCard(string holderName, DateTime expirDate, string cardNumber, string securityCode, bool saveCardDetails)
        {
            if (creditCard != null)  // ie is Factory is primed with an object. 
                return creditCard;
            else
                return new CreditCard(holderName, expirDate, cardNumber, securityCode, saveCardDetails);
        }
        public static void SetCreditCard(ICreditCard aCreditCard)
        {
            creditCard = aCreditCard;
        }
    }
}
