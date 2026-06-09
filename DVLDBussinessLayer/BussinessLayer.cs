using DVLDDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBussinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew, Update }

        private enMode Mode;
        public int Id { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; } }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email {  get; set; }
        public int CountryID { get; set; }
        public string ImagePath { get; set; }

        public clsPerson()
        {
            Id = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            NationalNo = "";
            Gender = ' ';
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            ImagePath = "";
            CountryID = -1;
            Mode = enMode.AddNew;
        }

        private clsPerson(int id, string firstName, string secondName, string thirdName, string lastName, string nationalNo, char gender, string email, string phone, string address, DateTime dateOfBirth, string imagePath, int countryID)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalNo = nationalNo;
            Gender = gender;
            Email = email;
            Phone = phone;
            Address = address;
            DateOfBirth = dateOfBirth;
            ImagePath = imagePath;
            CountryID = countryID;
            Mode = enMode.Update;
        }

        public static DataTable GetAllPeople()
        {
            return clsPersoneDataAccess.GetAllPeole();
        }
        public static DataTable GetPeoplebyID(string id)
        {
            return clsPersoneDataAccess.GetPeoleByID(id);
        }
        public static DataTable GetPeoleByNationalNo(string NationalNo)
        {
            return clsPersoneDataAccess.GetPeoleByNationalNo(NationalNo);
        }
        public static DataTable GetPeoleByFirstName(string Name)
        {
            return clsPersoneDataAccess.GetPeoleByFirstName(Name);
        }
        public static DataTable GetPeoleBySecondName(string Name)
        {
            return clsPersoneDataAccess.GetPeoleBySecondName(Name);
        }
        public static DataTable GetPeoleByThirdName(string Name)
        {
            return clsPersoneDataAccess.GetPeoleByThirdName(Name);
        }
        public static DataTable GetPeoleByLastName(string Name)
        {
            return clsPersoneDataAccess.GetPeoleByLastName(Name);
        }
        public static DataTable GetPeoleByNationaliaty(string CountryID)
        {
            return clsPersoneDataAccess.GetPeoleByNationality(CountryID);
        }
        public static DataTable GetPeoleByGender(char Gender)
        {
            return clsPersoneDataAccess.GetPeoleByGender(Gender);
        }
        public static DataTable GetPeoleByPhone(string Phone)
        {
            return clsPersoneDataAccess.GetPeoleByPhone(Phone);
        }
        public static DataTable GetPeoleByEmail(string Email)
        {
            return clsPersoneDataAccess.GetPeoleByEmail(Email);
        }

        public static clsPerson Find(int id)
        {
            string firstName = "", secondName = "", ThirdName = "", lastName = "", NationalNo = "", email = "", phone = "", address = "", imagePath = "";
            char Gender = ' ';
            int countryID = -1;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersoneDataAccess.GetPersonInfoByID(id, ref firstName,ref secondName,ref ThirdName, ref lastName,ref NationalNo,ref Gender, ref email, ref phone, ref address, ref DateOfBirth, ref countryID, ref imagePath))
            {

                return new clsPerson(id, firstName,secondName, ThirdName, lastName,NationalNo, Gender, email, phone, address, DateOfBirth, imagePath, countryID);
            }
            return null;

        }
        public static clsPerson FindByNationalNo(string NationalNo)
        {
            string firstName = "", secondName = "", ThirdName = "", lastName = "", email = "", phone = "", address = "", imagePath = "";
            char Gender = ' ';
            int countryID = -1, id = 0;
            DateTime DateOfBirth = DateTime.Now;

            if (clsPersoneDataAccess.GetPersonInfoByNationalNo(ref id, ref firstName,ref secondName,ref ThirdName, ref lastName,NationalNo,ref Gender, ref email, ref phone, ref address, ref DateOfBirth, ref countryID, ref imagePath))
            {

                return new clsPerson(id, firstName,secondName, ThirdName, lastName,NationalNo, Gender, email, phone, address, DateOfBirth, imagePath, countryID);
            }
            return null;

        }
        private bool _AddNewPerson()
        {
            this.Id = clsPersoneDataAccess.AddNewPerson(this.FirstName, this.SecondName, this.ThirdName, this.LastName,this.NationalNo,this.Gender, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
            return this.Id != -1;
        }
        private bool _UpdatePerson()
        {
            return clsPersoneDataAccess.UpdatePersone(this.Id, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.NationalNo, this.Gender, this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }
        public bool Save()
        {
            try
            {
                switch (this.Mode)
                {
                    case enMode.AddNew:
                        if (_AddNewPerson())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;

                    case enMode.Update:
                        return _UpdatePerson();
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                throw;
            }
        }
        public static bool IsPersonExist(string NationalNo)
        {
            return clsPersoneDataAccess.IsPersonExist(NationalNo);
        }
        public static bool DeletePerson(int id)
        {
            return clsPersoneDataAccess.DeletePerson(id);
        }
    }
}
