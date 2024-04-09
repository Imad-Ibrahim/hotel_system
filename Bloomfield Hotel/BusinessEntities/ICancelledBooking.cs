using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICancelledBooking
    {
        int CancelledBookingID { get; set; }
        int BookingID { get; set; }
        string GuestName { get; set; }
        int NumSingleRooms { get; set; }
        int NumDoubleRooms { get; set; }
        int NumTwinRooms { get; set; }
        double Total { get; set; }
        double TotalRefund { get; set; }
    }
}
