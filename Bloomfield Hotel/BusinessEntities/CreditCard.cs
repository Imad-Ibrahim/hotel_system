using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CreditCard : ICreditCard
    {
        public string HolderName { get; set; }
        public DateTime ExpirDate { get; set; }
        public string CardNumber { get; set; }
        public string SecurityCode { get; set; }
        public bool SaveCardDetails { get; set; }

        public CreditCard() { }

        public CreditCard(string holderName, DateTime expirDate, string cardNumber, string securityCode, bool saveCardDetails)
        {
            this.HolderName = holderName;
            this.ExpirDate = expirDate;
            this.CardNumber = cardNumber;
            this.SecurityCode = securityCode;
            this.SaveCardDetails = saveCardDetails;
        }
    }
}
