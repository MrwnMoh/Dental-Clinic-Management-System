using Business_Layer;
using DCMS.Appointments.Forms;
using DCMS.Doctors.Forms;
using DCMS.MultyUse.Forms;
using DCMS.Patients.Forms;
using DCMS.People.Forms;
using DCMS.Properties;
using DCMS.User.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS
{
    public class clsActions
    {
        public static event EventHandler OnCurrentUserEdit;

        public static event EventHandler OnDeleteOrEdit;


        //////////////

        public static void EditPerson(int PersonID)
        {
            clsPeople Person = clsPeople.Find(PersonID);
            EditPerson(Person);
        }

        public static void EditPerson(clsPeople Person)
        {
            frmAddEditPerson frm = new frmAddEditPerson(Person);


            frm.OnCurrentUserEdit += (s, e) =>
            {
                OnCurrentUserEdit?.Invoke(s, e);
            };
            
            frm.PersonSaved += (s, ev) => OnDeleteOrEdit?.Invoke(s, ev);
            frm.ShowDialog();
        }

        public static void DeletePerson(int PersonID)
        {
            frmDelete frm = new frmDelete();

            frm.OnDeleted += (s, e) =>
            {
                OnDeleteOrEdit?.Invoke(s, e);
            };

            frm._setForPerson(PersonID);

            frm.ShowDialog();
        }

        public static void ShowPersonDetails(int PersonID)
        {
            frmPersonDetails frm =new frmPersonDetails(PersonID);

            frm.OnEdit += OnDeleteOrEdit;
            frm.ShowDialog();
        }


        //////////////

        public static void EditUser (int UserID)
        {
            clsUsers User = clsUsers.Find(UserID);
            EditUser(User);
        }

        public static void EditUser(clsUsers User)
        {

            frmAddEditUser frm = new frmAddEditUser(User);

            frm.UserSaved += OnDeleteOrEdit;

            frm.ShowDialog();

        }

        public static void DeleteUser(int UserID)
        {
            frmDelete frm = new frmDelete();

            frm.OnDeleted += (s, e) =>
            {
                OnDeleteOrEdit?.Invoke(s, e);
            };

            frm._setForUser(UserID);
            frm.ShowDialog();

        }


        ////////////////
        public static void DeleteDoctor(int DoctorID)
        {
            frmDelete frm = new frmDelete();

            frm.OnDeleted += (s, e) =>
            {
                OnDeleteOrEdit?.Invoke(s, e);
            };
            
            frm._setForDoctor(DoctorID);
            frm.ShowDialog();
        }

        public static void EditDoctor(int DoctorID)
        {
           clsDoctors doctors = clsDoctors.Find(DoctorID);
            EditDoctor(doctors);
        }

        public static void EditDoctor(clsDoctors Doctor)
        {
            frmAddEditDoctor frm = new frmAddEditDoctor(Doctor);

            frm.Saved += OnDeleteOrEdit;

            frm.ShowDialog();

        }




        //==================================================
        public static void AddPatient()
        {
            frmAddNewPatient frm = new frmAddNewPatient();

            frm.Saved += OnDeleteOrEdit;

            frm.ShowDialog();

        }

        public static void DeletePatient(int PatientID)
        {
            frmDelete frm = new frmDelete();

            frm.OnDeleted += (s, e) =>
            {
                OnDeleteOrEdit?.Invoke(s, e);
            };

            frm._setForPatient(PatientID);
            frm.ShowDialog();
        }



        //==================================================

        public static void AddEditAppointment(int appointmentID)
        {

            clsAppointments App = clsAppointments.Find(appointmentID);

            AddEditAppointment(App);
        }


        public static void AddEditAppointment(clsAppointments appointments)
        {
            frmAddEditAppoiment frm = new frmAddEditAppoiment(appointments);

            frm.Saved += OnDeleteOrEdit;

            frm.ShowDialog();

        }

        public static void DeleteAppointment(int AppointmentID)
        {
            frmDelete frm = new frmDelete();

            frm.OnDeleted += (s, e) =>
            {
                OnDeleteOrEdit?.Invoke(s, e);
            };

            frm._setForAppoitment(AppointmentID);
            frm.ShowDialog();
        }



        ////////////////
        public static void PfpPerfoum(ref Guna2CirclePictureBox pbPic, string ImagePath,bool IsMale)
        {
            if (File.Exists(ImagePath))
            {
                pbPic.ImageLocation = null;
                pbPic.ImageLocation = ImagePath;
            }
            else
            {
                if (IsMale)
                {
                    pbPic.Image = Resources.Boy;
                }
                else
                {
                    pbPic.Image = Resources.Girl;
                }
            }
        }

    }
}
