using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Booking : IBooking
    {
        private const double singlePrice = 61.00;
        private const double doublePrice = 79.00;
        private const double twinPrice = 70.00;

        public int BookingID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string GuestNames { get; set; }
        public string AdditionalNotes { get; set; }
        public int NumSingleRooms { get; set; }
        public int NumDoubleRooms { get; set; }
        public int NumTwinRooms { get; set; }
        public List<IRoom> RoomList { get; set; }
        public bool CheckedIn { get; set; }
        public bool CheckedOut { get; set; }
        public double Total { get; set; }
        public IGuest Guest { get; set; }

        public Booking() { }

        public Booking(int bookingID, DateTime checkIn, DateTime checkOut, string guestNames, string additionalNotes, int numSingleRooms, int numDoubleRooms, int numTwinRooms, List<IRoom> roomList, bool checkedIn, bool checkedOut, IGuest guest)
        {
            this.BookingID = bookingID;
            this.CheckIn = checkIn;
            this.CheckOut = checkOut;
            this.GuestNames = guestNames;
            this.AdditionalNotes = additionalNotes;
            this.NumSingleRooms = numSingleRooms;
            this.NumDoubleRooms = numDoubleRooms;
            this.NumTwinRooms = numTwinRooms;
            this.RoomList = roomList;
            this.CheckedIn = checkedIn;
            this.CheckedOut = checkedOut;
            this.Total = (numSingleRooms * singlePrice) + (numDoubleRooms * doublePrice) + (numTwinRooms * twinPrice);
            this.Guest = guest;
        }
    }
}
