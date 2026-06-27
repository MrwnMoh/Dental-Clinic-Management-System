using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsAppointments
    {

        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string Notes { get; set; }
        public decimal Price { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAt { get; set; }

        public enum enAppointmentStatus
        {
            Pending = 1,
            Cancelled = 2,
            Completed = 3
        }

        public enAppointmentStatus Status { get; set; }

        public clsDoctors Doctor {  get; set; }
        public clsPatients Patient {  get; set; }

        public enum Mode { Update, AddNew };
        public Mode CurrnetMode;

        public clsAppointments()
        {
            AppointmentID = -1;
            PatientID = -1;
            DoctorID = -1;
            Price = -1;

            Status = enAppointmentStatus.Pending;

            AppointmentDate = DateTime.MinValue;
            CreatedAt = DateTime.Now;

            Notes = string.Empty;

            Doctor = null;
            Patient = null;

            CurrnetMode = Mode.AddNew;

        }

        private clsAppointments(int appointmentID, int patientID, int doctorID, byte status, string notes, decimal price, DateTime appointmentDate, DateTime createdAt)
        {
            AppointmentID = appointmentID;
            PatientID = patientID;
            DoctorID = doctorID;
            Status = (enAppointmentStatus)status;
            Notes = notes;
            Price = price;
            AppointmentDate = appointmentDate;
            CreatedAt = createdAt;

            Doctor = clsDoctors.Find(DoctorID);
            Patient = clsPatients.Find(PatientID);

            CurrnetMode = Mode.Update;
        }

        private bool _UpdateAppointment()
        {
            return clsAppointmentsData.UpdateAppointment(
                AppointmentID,
                AppointmentDate,
                Notes,
                (byte)Status,
                Price);
        }

        private bool _AddNewAppointment()
        {
            CreatedAt = DateTime.Now;

            AppointmentID = clsAppointmentsData.AddAppointment(
                PatientID,
                DoctorID,
                Notes,
                Price,
                AppointmentDate);

            return AppointmentID != -1;
        }

        public bool Save()
        {
            switch (CurrnetMode)
            {
                case Mode.AddNew:

                    if (_AddNewAppointment())
                    {
                        CurrnetMode = Mode.Update;
                        return true;
                    }

                    return false;

                case Mode.Update:
                    return _UpdateAppointment();
            }

            return false;
        }

        public static DataTable GetAppointmentsSummary()
        {
            return clsAppointmentsData.GetAppointmentsSummary();
        }

        public static clsAppointments Find(int AppointmentID)
        {
            int PatientID = -1, DoctorID = -1;
            byte Status = 1;
            string Notes = string.Empty;
            decimal Price = 0;
            DateTime AppointmentDate = DateTime.MinValue, CreatedAt = DateTime.MinValue;

            if (clsAppointmentsData.FindAppointmentByID(AppointmentID, ref PatientID, ref DoctorID, ref Status, ref Notes, ref Price, ref AppointmentDate, ref CreatedAt))
            {
                return new clsAppointments(AppointmentID, PatientID, DoctorID, Status, Notes, Price, AppointmentDate, CreatedAt);
            }

            return null;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            return clsAppointmentsData.DeleteAppointment(AppointmentID);
        }

        public static bool Cancel(int AppointmentID)
        {
            if (clsAppointmentsData.CancelAppointment(AppointmentID))
            {
                return true;
            }

            return false;
        }

        public static DataTable GetAppointmentTreatments(int appointmentID)
        {
            return clsAppointmentsData.GetAppointmentTreatments(appointmentID);
        }

        public static decimal GetTotalAppointmentPaid(int appointmentID)
        {
            return clsAppointmentsData.GetTotalAppointmentPaid(appointmentID);
        }


    }
}
