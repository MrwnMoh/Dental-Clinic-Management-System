using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsPeople
    {
        public int    PersonID { get; set; }
        public int    BloodTypeID { get; set; }
        public int    CountryID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ImagePath { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMale { get; set; }
        

        public enum Mode { Update,AddNew};
        public Mode CurrnetMode;
        
        

        public clsBloodType BloodType { get; set; }
        public clsCountrys Country {  get; set; }

        public clsPeople()
         {
             PersonID = -1;
             CountryID = -1;
            BloodTypeID = -1;
             FirstName = string.Empty;
             LastName = string.Empty;
             Address = string.Empty;
             Email = string.Empty;
             Phone = string.Empty;
             ImagePath = string.Empty;
        
             BirthDate = DateTime.MinValue;
             IsMale = true;

            CurrnetMode = Mode.AddNew;

            BloodType = new clsBloodType();
            Country = new clsCountrys();
         }

        private clsPeople(int personID, int bloodTypeID, int countryID, string firstName, string lastName, string address, string email, string phone, string imagePath, DateTime birthDate, bool isMale )
        {
            PersonID = personID;
            BloodTypeID = bloodTypeID;
            CountryID = countryID;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Email = email;
            Phone = phone;
            ImagePath = imagePath;
            BirthDate = birthDate;
            IsMale = isMale;


            BloodType = clsBloodType.Find(bloodTypeID);
            Country = clsCountrys.GetCountryByID(countryID);
            CurrnetMode = Mode.Update;
        }

        public static DataTable LoadAllPeople()
        {
            return clsPeopleData.GetAllPeople();
        }

        public static clsPeople Find(int ID)
        {
            int BloodTypeID = 0;
            int CountryID = 0;
            string FirstName = "";
            string LastName = "";
            string Address = "";
            string Email = "";
            string Phone = "";
            string ImagePath = "";
            DateTime BirthDate = DateTime.Now;
            bool IsMale = true;

            if (clsPeopleData.FindPersonByID(
ID,
ref BloodTypeID,
ref CountryID,
ref FirstName,
ref LastName,
ref Address,
ref Email,
ref Phone,
ref ImagePath,
ref BirthDate,
ref IsMale))
            {
                return new clsPeople(
                    ID,
                    BloodTypeID,
                    CountryID,
                    FirstName,
                    LastName,
                    Address,
                    Email,
                    Phone,
                    ImagePath,
                    BirthDate,
                    IsMale);
            }

            return null;
        }

        private bool AddNewPerson()
        {
            PersonID = clsPeopleData.AddNewPerson(BloodTypeID, CountryID, FirstName, LastName,Address, Email,Phone,ImagePath,BirthDate,IsMale);

            return PersonID != -1;
        }

        private bool UpdatePerson()
        {
            return clsPeopleData.UpdatePerson(PersonID,BloodTypeID,CountryID,FirstName,LastName,Address,Email,Phone,ImagePath,BirthDate,IsMale);
        }

        public bool Save()
        {
            switch (CurrnetMode)
            {
                case Mode.Update:
                    return UpdatePerson();
                case Mode.AddNew:
                    if(AddNewPerson())
                    {
                        CurrnetMode = Mode.Update;
                        return true;
                    }
                    return false;
                default:
                    return false;
            }
        }

        public bool DeletePerson()
        {
            return clsPeopleData.DeletePerson(PersonID);    
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);
        }

    }
}
