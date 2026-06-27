using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsSpecialization
    {


        public int SpecializationID { get; set; }
        public string SpecializationName { get; set; }



        public clsSpecialization()
        {
            SpecializationID = -1;
            SpecializationName = string.Empty;
        }

        clsSpecialization(int specializationID, string specializationName)
        {
            SpecializationID = specializationID;
            SpecializationName = specializationName;
        }

        public static DataTable GetAllSpecializations()
        {
            return clsSpecializationData.GetAllSpecializations();
        }

        public static clsSpecialization GetSpecializationByID(int specializationID)
        {
            string name = string.Empty;
            if (clsSpecializationData.GetSpecializationByID(specializationID, ref name))
            {
                return new clsSpecialization(specializationID, name);
            }

            return null;
        }


    }
}
