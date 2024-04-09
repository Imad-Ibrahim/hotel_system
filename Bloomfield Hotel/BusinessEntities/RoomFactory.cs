using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RoomFactory
    {
        private static IRoom room = null;
        public static IRoom GetRoom(int roomNumber, int floor, string roomType, bool available, bool clean, bool assigned)
        {
            return new Room(roomNumber, floor, roomType, available, clean, assigned);
        }
        public static void SetRoom(IRoom aRoom)
        {
            room = aRoom;
        }
    }
}
