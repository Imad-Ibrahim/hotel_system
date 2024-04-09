using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CancelledBooking : ICancelledBooking
    {
        public int CancelledBookingID { get; set; }
        public int BookingID { get; set; }
        public string GuestName { get; set; }
        public int NumSingleRooms { get; set; }
        public int NumDoubleRooms { get; set; }
        public int NumTwinRooms { get; set; }
        public double Total { get; set; }
        public double TotalRefund { get; set; }

        public CancelledBooking() { }

        public CancelledBooking(int cancelledBookingID, int bookingID, string guestName, int numSingleRooms, int numDoubleRooms, int numTwinRooms, double total, double totalRefund)
        {
            this.CancelledBookingID = cancelledBookingID;
            this.BookingID = bookingID;
            this.GuestName = guestName;
            this.NumSingleRooms = numSingleRooms;
            this.NumDoubleRooms = numDoubleRooms;
            this.NumTwinRooms = numTwinRooms;
            this.Total = total;
            this.TotalRefund = totalRefund;
        }
    }
}
