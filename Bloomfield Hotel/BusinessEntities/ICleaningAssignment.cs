using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICleaningAssignment
    {
        DateTime assignedOn { get; set; }
        IRoom room { get; set; }
        List<IUser> cleaners { get; set; }
        IUser assignedBy { get; set; }
        bool complete { get; set; }
    }
}
