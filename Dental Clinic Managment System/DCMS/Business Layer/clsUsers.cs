using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsUsers
    {

        public int UserID { get; set; }
        public int PersonID { get; set; }
        public int CreatedByID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

        public enum Mode { Update, AddNew };
        public Mode CurrnetMode;

        public clsPeople Person { get; set; }

        public clsUsers()
        {
            UserID = -1;
            PersonID = -1;
            CreatedByID = -1;
            Username = string.Empty;
            Password = string.Empty;
            CreatedAt = DateTime.MinValue;

            IsActive = false;
            IsAdmin = false;


            CurrnetMode = Mode.AddNew;

        }

        private clsUsers(int userID,int personID,int createdBy,string userName,string password,DateTime createdAt,bool isActive,bool isAdmin)
        {
            UserID = userID;
            PersonID = personID;
            CreatedByID = createdBy;
            Username = userName;
            Password = password;
            CreatedAt = createdAt;
            IsActive = isActive;
            IsAdmin = isAdmin;

            CurrnetMode = Mode.Update;

            Person = clsPeople.Find(PersonID);

        }

        public static bool IsPersonAdmin(int PersinID)
        {
            return clsUsersData.IsAdmin(PersinID);
        }

        public static bool IsPersonPatient(int PersinID)
        {
            return clsUsersData.IsPatient(PersinID);
        }

        public static bool IsPersonDoctor(int PersinID)
        {
            return clsUsersData.IsPersonDoctor(PersinID);
        }

        public static bool IsUserDoctor(int UserID)
        {
            return clsUsersData.IsUserDoctor(UserID);
        }


        public static DataTable LoadAllUsers()
        {
            return clsUsersData.GetAllUsers();
        }

        public static DataTable GetAllUsersInfoWithPeople()
        {
            return clsUsersData.GetAllUsersInfoWithPeople();
        }

        public static clsUsers Find(int UserID)
        {
            int PersonID = 0;
            int CreatedBy = -1;

            string Username = "";
            string Password = "";

            DateTime CreatedAt = DateTime.Now;

            bool IsActive = false;
            bool IsAdmin = false;

            if (clsUsersData.FindUserByID(
                UserID,
                ref PersonID,
                ref CreatedBy,
                ref Username,
                ref Password,
                ref CreatedAt,
                ref IsActive,
                ref IsAdmin
                ))
            {
                return new clsUsers(
                    UserID,
                    PersonID,
                    CreatedBy,
                    Username,
                    Password,
                    CreatedAt,
                    IsActive,
                    IsAdmin
                    );
            }

            return null;
        }

        public static clsUsers FindByPersonID(int PersonID)
        {
            int UserID = 0;
            int CreatedBy = -1;

            string Username = "";
            string Password = "";

            DateTime CreatedAt = DateTime.Now;

            bool IsActive = false;
            bool IsAdmin = false;

            if (clsUsersData.FindUserByPersonID(
                PersonID,
                ref UserID,
                ref CreatedBy,
                ref Username,
                ref Password,
                ref CreatedAt,
                ref IsActive,
                ref IsAdmin
                ))
            {
                return new clsUsers(
                    UserID,
                    PersonID,
                    CreatedBy,
                    Username,
                    Password,
                    CreatedAt,
                    IsActive,
                    IsAdmin
                    );
            }

            return null;
        }

        private bool AddNewUser()
        {
            UserID = clsUsersData.AddNewUser(
                PersonID,
                CreatedByID,
                Username,
                Password,
                IsActive,
                IsAdmin
                );

            return UserID != -1;
        }

        private bool UpdateUser()
        {
            return clsUsersData.UpdateUser(UserID,Username,Password,IsActive,IsAdmin);
        }

        public bool Save()
        {
            switch (CurrnetMode)
            {
                case Mode.Update:
                    return UpdateUser();

                case Mode.AddNew:
                    if (AddNewUser())
                    {
                        CurrnetMode = Mode.Update;
                        return true;
                    }
                    return false;

                default:
                    return false;
            }
        }

        public static clsUsers FindByUsernameAndPassword(string Username, string Password)
        {
            int UserID = 0;
            int PersonID = 0;
            int CreatedBy = -1;

            DateTime CreatedAt = DateTime.Now;

            bool IsActive = false;
            bool IsAdmin = false;

            if (clsUsersData.FindUserByUsernameAndPassword(
                Username,
                Password,
                ref UserID,
                ref PersonID,
                ref CreatedBy,
                ref CreatedAt,
                ref IsActive,
                ref IsAdmin
                 ))
            {
                return new clsUsers(
                    UserID,
                    PersonID,
                    CreatedBy,
                    Username,
                    Password,
                    CreatedAt,
                    IsActive,
                    IsAdmin
                    );
            }

            return null;
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }

        public static string GetUsernameByUserID(int UserID)
        {
            return clsUsersData.GetUsernameByUserID(UserID);
        }

    }
}
