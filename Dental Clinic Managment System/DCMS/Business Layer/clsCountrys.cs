using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsCountrys
    {

        public int CountryID { get; }
        public string CountryName { get; }


        public clsCountrys()
        {
            CountryID = -1;
            CountryName = string.Empty;
        }

        private clsCountrys(int countryID, string countryName)
        {
            CountryID = countryID;
            CountryName = countryName;
        }

        public static DataTable LoadAllCountrysNames()
        {
            return clsCountrysData.LoadAllCountrysNames();
        }

        public static clsCountrys GetCountryByID(int countryID)
        {
            string name = string.Empty;
            if(clsCountrysData.GetCountryByID(countryID,ref name))
            {
                return new clsCountrys(countryID,name);
            }

            return null;
        }

    }
}
