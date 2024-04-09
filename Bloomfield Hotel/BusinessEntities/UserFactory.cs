using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class UserFactory
    {
        private static IUser user=null;

        public static IUser CreateUser(int userID, string password, string firstName, string lastName, string email, string phone, DateTime dob, string userType)
        {
            switch (userType)
            {
                case "Admin":
                    return new Admin(userID, password, firstName, lastName, email, phone, dob);
                case "BarManager":
                    return new BarManager(userID, password, firstName, lastName, email, phone, dob);
                case "BarStaff":
                    return new BarStaff(userID, password, firstName, lastName, email, phone, dob);
                case "Chef":
                    return new Chef(userID, password, firstName, lastName, email, phone, dob);
                case "Cleaner":
                    return new Cleaner(userID, password, firstName, lastName, email, phone, dob);
                case "CleaningSuper":
                    return new CleaningSuper(userID, password, firstName, lastName, email, phone, dob);
                case "Manager":
                    return new Manager(userID, password, firstName, lastName, email, phone, dob);
                case "Receptionist":
                    return new Receptionist(userID, password, firstName, lastName, email, phone, dob);             
                default:
                    return user;
            }
        }
        public static IUser GetUser(int userID, string username, string password, string firstName, string lastName, string email, string phone, DateTime dob, string userType)
        {
            switch (userType)
            {
                case "Admin":
                    return new Admin(userID, username, password, firstName, lastName, email, phone, dob);
                case "BarManager":
                    return new BarManager(userID, username, password, firstName, lastName, email, phone, dob);
                case "BarStaff":
                    return new BarStaff(userID, username, password, firstName, lastName, email, phone, dob);
                case "Chef":
                    return new Chef(userID, username, password, firstName, lastName, email, phone, dob);
                case "Cleaner":
                    return new Cleaner(userID, username, password, firstName, lastName, email, phone, dob);
                case "CleaningSuper":
                    return new CleaningSuper(userID, username, password, firstName, lastName, email, phone, dob);
                case "Manager":
                    return new Manager(userID, username, password, firstName, lastName, email, phone, dob);
                case "Receptionist":
                    return new Receptionist(userID, username, password, firstName, lastName, email, phone, dob);
                default:
                    return user;
            }
        }
        public static void SetUser(IUser aUser)
        {
            user = aUser; 
        }
    }
}
