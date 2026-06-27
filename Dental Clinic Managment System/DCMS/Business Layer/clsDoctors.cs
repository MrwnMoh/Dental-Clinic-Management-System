using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsDoctors
    {

        public int DoctorID { get; set; }
        public int UserID { get; set; }
        public int SpecializationID { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public DateTime? LeaveDate { get; set; }

        public clsUsers User { get; set; }
        public clsSpecialization Specialization { get; set; }

        public enum Mode { Update, AddNew };
        public Mode CurrnetMode;

        public clsDoctors()
        {
            DoctorID = -1;
            UserID = -1;
            SpecializationID = -1;
            Salary = -1;
            HiringDate = DateTime.MinValue;
            LeaveDate = null;

            User = new clsUsers();
            Specialization = new clsSpecialization();

            CurrnetMode = Mode.AddNew;
        }

        private clsDoctors(int doctorID, int userID, int specializationID, decimal salary, DateTime hiringDate, DateTime? leaveDate)
        {
            DoctorID = doctorID;
            UserID = userID;
            SpecializationID = specializationID;
            Salary = salary;
            HiringDate = hiringDate;
            LeaveDate = leaveDate;

            User = clsUsers.Find(UserID);
            Specialization = clsSpecialization.GetSpecializationByID(specializationID);

            CurrnetMode = Mode.Update;
        }

        private bool _AddNewDoctor()
        {

            DoctorID =  clsDoctorsData.AddDoctor(
                this.UserID,
                this.SpecializationID,
                this.Salary,
                this.HiringDate,
                this.LeaveDate);

            return DoctorID != -1;
        }

        private bool _UpdateDoctor()
        {
            return clsDoctorsData.UpdateDoctor(DoctorID, SpecializationID, Salary, HiringDate, LeaveDate); ;
        }

        public bool Save()
        {
            switch (CurrnetMode)
            {
                case Mode.Update:
                    return _UpdateDoctor();

                case Mode.AddNew:
                    if (_AddNewDoctor())
                    {
                        CurrnetMode = Mode.Update;
                        return true;
                    }
                    return false;

                default:
                    return false;
            }
        }

        public static clsDoctors Find(int DoctorID)
        {
            int UserID = -1;
            int SpecializationID = -1;
            decimal Salary = 0;
            DateTime HiringDate = DateTime.Now;
            DateTime? LeaveDate = null;


            if(clsDoctorsData.FindDoctorByID(DoctorID,ref UserID,ref SpecializationID,ref Salary,ref HiringDate,ref LeaveDate))
            {
                return new clsDoctors(DoctorID, UserID, SpecializationID, Salary, HiringDate, LeaveDate);
             
            }
      

            return null;
        }

        public static clsDoctors FindByUserID(int UserID)
        {
            int DoctorID = -1;
            int SpecializationID = -1;
            decimal Salary = 0;
            DateTime HiringDate = DateTime.Now;
            DateTime? LeaveDate = null;

            if (clsDoctorsData.FindDoctorByUserID(UserID, ref DoctorID, ref SpecializationID, ref Salary, ref HiringDate, ref LeaveDate))
            {
                return new clsDoctors(DoctorID, UserID, SpecializationID, Salary, HiringDate, LeaveDate);
            }

            return null;
        }

        public static DataTable GetDoctorsDataWithDetails()
        {
            return clsDoctorsData.GetDoctorsDataWithDetails();
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            return clsDoctorsData.DeleteDoctor(DoctorID);
        }

    }
}
