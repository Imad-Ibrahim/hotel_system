using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Room : IRoom
    {
        public int roomNumber { get; set; }
        public int floor { get; set; }
        public string roomType { get; set; }
        public bool available { get; set; }
        public bool clean { get; set; }
        public bool assigned { get; set; }
        public Room()
        {
            this.roomNumber = 0;
            this.floor = 0;
            this.roomType = "";
            this.available = false;
            this.clean = true;
            this.assigned = assigned;
        }
        public Room(int roomNumber, int floor, string roomType, bool available, bool clean, bool assigned)
        {
            this.roomNumber = roomNumber;
            this.floor = floor;
            this.roomType = roomType;
            this.available = available;
            this.clean = clean;
            this.assigned = assigned;
        }
        public void CheckIn()
        {
            this.available = false;
        }
        public void CheckOut()
        {
            this.clean = false;
        }
        public void Assign()
        {
            this.assigned = true;
        }
        public void CancelAssignment()
        {
            this.assigned = false;
        }
        public void Clean()
        {
            this.available = true;
            this.clean = true;
            this.assigned = false;
        }
    }
}
