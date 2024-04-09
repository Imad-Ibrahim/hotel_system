using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class User : IUser
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime dob { get; set; }

        public User()
        {
            this.username = "";
            this.password = "";
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User(int userID, string password, string firstName, string lastName, string email, string phone, DateTime dob)
        {
            this.userID = userID;
            this.username = firstName[0] + "." + lastName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.dob = dob;
        }
        public User(int userID, string username, string password, string firstName, string lastName, string email, string phone, DateTime dob)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.dob = dob;
        }

        public bool CheckLoginDetails(User u)
        {
            if (this.username.Equals(u.username) && this.password.Equals(u.password))
                return true;
            else
                return false;
        }
        public void ExtendUsername(int lastChar)
        {
            this.username = firstName.Substring(0, lastChar) + "." + lastName;
        }
    }
}
