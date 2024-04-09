using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CleaningAssignment : ICleaningAssignment
    {
        public DateTime assignedOn { get; set; }
        public IRoom room { get; set; }
        public List<IUser> cleaners { get; set; }
        public IUser assignedBy { get; set; }
        public bool complete { get; set; }
        public CleaningAssignment()
        {
            this.assignedOn = DateTime.Today;
            this.room = null;
            this.cleaners = new List<IUser>();
            this.assignedBy = null;
            this.complete = false;
        }
        public CleaningAssignment(IRoom room, List<IUser> cleaners, IUser assignedBy)
        {
            this.assignedOn = DateTime.Today;
            this.room = room;
            this.cleaners = cleaners;
            this.assignedBy = assignedBy;
            this.complete = false;
        }
        public CleaningAssignment(DateTime assignedOn, IRoom room, List<IUser> cleaners, IUser assignedBy, bool complete)
        {
            this.assignedOn = assignedOn;
            this.room = room;
            this.cleaners = cleaners;
            this.assignedBy = assignedBy;
            this.complete = complete;
        }
    }
}
