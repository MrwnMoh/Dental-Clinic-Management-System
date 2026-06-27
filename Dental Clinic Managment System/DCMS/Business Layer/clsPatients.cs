using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsPatients
    {

        public int PatientID { get; set; }
        public int PersonID { get; set; }
        public DateTime CreatedAt { get; set; }

        public clsPeople Person { get; set; }


        public clsPatients() 
        { 
            PatientID = -1;
            PersonID = -1;
            Person = null;
        }

        private clsPatients (int patientID, int personID, DateTime createdAt)
        {
            PatientID = patientID;
            PersonID = personID;
            CreatedAt = createdAt;
            Person = clsPeople.Find(personID);
        }

        private bool _AddNewPatient()
        {
            this.PatientID = clsPatientsData.AddPatient(this.PersonID);

            return this.PatientID != -1;
        }

        public static clsPatients Find(int PatientID)
        {
            int PersonID = -1;
            DateTime CreatedAt = DateTime.MinValue;

            if (clsPatientsData.FindPatientByID(PatientID, ref PersonID, ref CreatedAt))
            {
                return new clsPatients(PatientID, PersonID, CreatedAt);
            }

            return null;
        }

        public static clsPatients FindByPersonID(int PersonID)
        {
            int PatientID = -1;
            DateTime CreatedAt = DateTime.MinValue;

            if (clsPatientsData.FindPatientByPersonID(PersonID, ref PatientID, ref CreatedAt))
            {
                return new clsPatients(PatientID, PersonID, CreatedAt);
            }

            return null;
        }

        public static bool DeletePatient(int PatientID)
        {
            return clsPatientsData.DeletePatient(PatientID);
        }

        public bool Save()
        {
            return _AddNewPatient();
        }

        public static DataTable GetSummaryPatientData()
        {
            return clsPatientsData.GetSummaryPatientData();
        }
    }
}
