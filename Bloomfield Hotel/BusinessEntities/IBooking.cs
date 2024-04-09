using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IBooking
    {
        int BookingID { get; set; }
        DateTime CheckIn { get; set; }
        DateTime CheckOut { get; set; }
        string GuestNames { get; set; }
        string AdditionalNotes { get; set; }
        int NumSingleRooms { get; set; }
        int NumDoubleRooms { get; set; }
        int NumTwinRooms { get; set; }
        List<IRoom> RoomList { get; set; }
        bool CheckedIn { get; set; }
        bool CheckedOut { get; set; }
        double Total { get; set; }
        IGuest Guest { get; set; }
    }
}
