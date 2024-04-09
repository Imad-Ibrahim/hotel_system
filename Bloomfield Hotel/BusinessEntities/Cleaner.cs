using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Cleaner : User
    {
        public Cleaner(int userID, string password, string firstName, string lastName, string email, string phone, DateTime dob) : base(userID, password, firstName, lastName, email, phone, dob)
        { }
        public Cleaner(int userID, string username, string password, string firstName, string lastName, string email, string phone, DateTime dob) : base(userID, username, password, firstName, lastName, email, phone, dob)
        { }
    }
}
