using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IUser
    {
        int userID { get; set; }
        string username { get; set; }
        string password { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string email { get; set; }
        string phone { get; set; }
        DateTime dob { get; set; }
        bool CheckLoginDetails(User u);
        void ExtendUsername(int lastChar);
    }
}
