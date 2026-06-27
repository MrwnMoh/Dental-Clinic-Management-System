using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsBloodType
    {
        public int BloodTypeID { get; }
        public string BloodName { get;}

        public clsBloodType()
        {
            BloodTypeID = 0;
            BloodName = string.Empty;
        }

        clsBloodType(int bloodTypeID, string bloodName)
        {
            BloodTypeID = bloodTypeID;
            BloodName = bloodName;
        }

        public static DataTable LoadAllBloodTypes()
        {
            return clsBloodTypeData.GetAllBloodTypes();
        }

        public static clsBloodType Find(int id)
        {
            string bloodName = "";

            if(clsBloodTypeData.GetBloodbyID(id,ref bloodName))
            {
                return new clsBloodType(id,bloodName);
            }

            return null;

        }


    }
}
