using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CleaningAssignmentFactory
    {
        private static ICleaningAssignment assignment = null;
        public static ICleaningAssignment CreateAssignment(IRoom room, List<IUser> cleaners, IUser assignedBy)
        {
            return new CleaningAssignment(room, cleaners, assignedBy);
        }
        public static ICleaningAssignment GetAssignment(DateTime assignedOn, IRoom room, List<IUser> cleaners, IUser assignedBy, bool complete)
        {
            return new CleaningAssignment(assignedOn, room, cleaners, assignedBy, complete);
        }
        public static void SetCleaningAssignment(ICleaningAssignment anAssignment)
        {
            assignment = anAssignment;
        }
    }
}
