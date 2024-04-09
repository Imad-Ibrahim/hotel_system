using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICreditCard
    {
        string HolderName { get; set; }
        DateTime ExpirDate { get; set; }
        string CardNumber { get; set; }
        string SecurityCode { get; set; }
        bool SaveCardDetails { get; set; }
    }
}
