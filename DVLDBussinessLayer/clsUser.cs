using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew, Update }
        private enMode Mode;
        public int Id { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }


        public clsUser()
        {
            Id = 0;
            PersonID = 0;
            UserName = "";
            Password = "";
            IsActive = false;
            Mode = enMode.AddNew;
        }
        public clsUser(int id, int personID, string userName, string password, bool isActive)
        {
            Id = id;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Mode = enMode.Update;
        }

        public static clsUser FindUserByUserNameAndPassword(string  username, string password)
        {
            int UserID = 0;
            int PersonID = 0;
            bool isActive = false;
            if (clsUserData.FindByUserNameAndPassword(username,password,ref PersonID,ref UserID, ref isActive))
            {
                return new clsUser(UserID,PersonID,username,password, isActive);
            }
            return null;
        }
        public static clsUser Find(int ID)
        {
            string UserName = "";
            int PersonID = 0;
            string Password = "";
            bool isActive = false;
            if (clsUserData.Find(ID, ref PersonID, ref UserName, ref Password, ref isActive))
            {
                return new clsUser(ID,PersonID, UserName, Password, isActive);
            }
            return null;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool IsUserExists(int id)
        {
            return clsUserData.IsUserExist(id);  
        }
        private bool _AddNewUser()
        {
            this.Id = clsUserData.AddNewUser(this.PersonID,this.UserName, this.Password,this.IsActive);
            return this.Id != -1;
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.Id,  this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewUser())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdateUser();
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }
    }
}
