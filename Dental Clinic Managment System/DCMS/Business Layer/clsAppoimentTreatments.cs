using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsAppoimentTreatments
    {
        public int AppointmentTreatmentID {  get; set; }
        public int TreatmenID { get;set; }
        public int AppoimentID { get; set; }
        public decimal UnitPrice { get; set; }

        public clsTreatments Treatment { get; set; }

        public clsAppoimentTreatments()
        {
            AppointmentTreatmentID = -1;
            TreatmenID = -1;
            AppoimentID = -1;
            UnitPrice =-1;

            Treatment = null;
        }


        private bool _AddNewAppointmentTreatment()
        {
            AppointmentTreatmentID = clsAppoimentTreatmentsData.AddAppointmentTreatment(
                AppoimentID,
                TreatmenID,
                UnitPrice);

            return AppointmentTreatmentID != -1;
        }

        public bool Save()
        {
                if (_AddNewAppointmentTreatment())
                {
                    return true;
                }
            return false;
        }


       

    }
}
