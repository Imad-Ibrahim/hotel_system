using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CancelledBookingFactory
    {
        private static ICancelledBooking cancelledBooking = null;

        public static ICancelledBooking GetCancelledBooking(int cancelledBookingID, int bookingID, string guestName, int numSingleRooms, int numDoubleRooms, int numTwinRooms, double total, double totalRefund)
        {
            if (cancelledBooking != null)  // ie is Factory is primed with an object. 
                return cancelledBooking;
            else
                return new CancelledBooking(cancelledBookingID, bookingID, guestName, numSingleRooms, numDoubleRooms, numTwinRooms, total, totalRefund);
        }
        public static void SetBooking(ICancelledBooking aCancelledBooking)
        {
            cancelledBooking = aCancelledBooking;
        }
    }
}
