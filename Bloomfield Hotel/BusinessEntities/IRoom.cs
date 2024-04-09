using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IRoom
    {
        int roomNumber { get; set; }
        int floor { get; set; }
        string roomType { get; set; }
        bool available { get; set; }
        bool clean { get; set; }
        bool assigned { get; set; }
        void CheckIn();
        void CheckOut();
        void Assign();
        void CancelAssignment();
        void Clean();
    }
}
