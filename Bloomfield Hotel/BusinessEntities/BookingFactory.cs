using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BookingFactory
    {
        private static IBooking booking = null;

        public static IBooking GetBooking(int bookingID, DateTime checkIn, DateTime checkOut, string guestNames, string additionalNotes, int numSingleRooms,
            int numDoubleRooms, int numTwinRooms, List<IRoom> roomList, bool checkedIn, bool checkedOut, IGuest guest)
        {
            if (booking != null)  // ie is Factory is primed with an object. 
                return booking;
            else
                return new Booking(bookingID, checkIn, checkOut, guestNames, additionalNotes, numSingleRooms, numDoubleRooms, numTwinRooms, roomList, checkedIn, checkedOut, guest);
        }
        public static void SetBooking(IBooking aBooking)
        {
            booking = aBooking;
        }
    }
}
