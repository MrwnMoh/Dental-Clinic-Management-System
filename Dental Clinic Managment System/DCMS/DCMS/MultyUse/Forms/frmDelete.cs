using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.MultyUse.Forms
{
    public partial class frmDelete : Form
    {
         enum eDeleteMode { Person, User, Doctor ,Patient,Appoitment}
         eDeleteMode Mode;

        public event EventHandler OnDeleted;

        clsPeople _Person;

        clsUsers _User;

        clsDoctors _Doctor;

        clsPatients _Patient;


        int _AppotmentID;

        public frmDelete()
        {
            InitializeComponent();
        }

        public void _setForPerson(int PersonID)
        {
            _Person = clsPeople.Find(PersonID);

            lblDeleteText.Text = "Delete Person";

            clsActions.PfpPerfoum(ref pbPic, _Person.ImagePath, _Person.IsMale);
            lblName.Text = _Person.FirstName + " " + _Person.LastName;

            Mode = eDeleteMode.Person;

            SetRoles(PersonID);
        }

        public void _setForUser(int UserID)
        {
            _User = clsUsers.Find(UserID);

            lblDeleteText.Text = "Delete User";

            clsActions.PfpPerfoum(ref pbPic, _User.Person.ImagePath, _User.Person.IsMale);
            lblName.Text = _User.Person.FirstName + " " + _User.Person.LastName;
            Mode = eDeleteMode.User;

            SetRoles(_User.PersonID);

        }

        public void _setForDoctor(int DoctorID)
        {
            _Doctor = clsDoctors.Find(DoctorID);

            lblDeleteText.Text = "Delete Doctor";

            clsActions.PfpPerfoum(ref pbPic, _Doctor.User.Person.ImagePath, _Doctor.User.Person.IsMale);
            lblName.Text = _Doctor.User.Person.FirstName + " " + _Doctor.User.Person.LastName;

            Mode = eDeleteMode.Doctor;

            SetRoles(_Doctor.User.PersonID);

        }

        public void _setForPatient(int Patient)
        {
            _Patient = clsPatients.Find(Patient);

            lblDeleteText.Text = "Delete Patient";

            clsActions.PfpPerfoum(ref pbPic, _Patient.Person.ImagePath, _Patient.Person.IsMale);
            lblName.Text = _Patient.Person.FirstName + " " + _Patient.Person.LastName;

            Mode = eDeleteMode.Patient;

            SetRoles(_Patient.PersonID);

        }

        public void _setForAppoitment(int AppotmentID)
        {
            _AppotmentID = AppotmentID;

            lblDeleteText.Text = "Delete Appoitment";

            panel.Visible = false;
            DeleteAppoitemnt.Visible = true;

            Mode = eDeleteMode.Appoitment;

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool Deleted = false;
            
            bool IsTryToDeleteSelf = false;


            switch (Mode)
            {
                case eDeleteMode.Person:
                    if(clsSettings.CurrentUser.PersonID != _Person.PersonID)
                    {
                        if (clsPeople.DeletePerson(_Person.PersonID))
                        {
                            Deleted = true;
                        }
                    }
                    else
                    {
                        IsTryToDeleteSelf = true;
                    }
                        break;
                case eDeleteMode.User:

                    if (clsSettings.CurrentUser.UserID != _User.UserID)
                    {
                        if (clsUsers.DeleteUser(_User.UserID))
                        {
                            Deleted = true;
                        }
                    }
                    else
                        IsTryToDeleteSelf = true;

                        break;
                case eDeleteMode.Doctor:
                    if (clsSettings.CurrentUser.UserID != _Doctor.UserID)
                    {
                        if (clsDoctors.DeleteDoctor(_Doctor.DoctorID))
                        {
                            Deleted = true;
                        }
                    }
                    else
                        { IsTryToDeleteSelf = true; }

                        break;
                case eDeleteMode.Patient:
                    if (clsSettings.CurrentUser.PersonID != _Patient.PersonID)
                    {
                        if (clsPatients.DeletePatient(_Patient.PatientID))
                        {
                            Deleted = true;
                        }
                    }
                    else
                    { IsTryToDeleteSelf = true; }
                    break;
                case eDeleteMode.Appoitment:
                        if (clsAppointments.DeleteAppointment(_AppotmentID))
                        {
                            Deleted = true;
                        }
                    break;

                default:
                    break;
            }

            if (Deleted)
            {
                OnDeleted?.Invoke(null, EventArgs.Empty);
                MessageBox.Show(
                    $"{Mode} deleted successfully.",
                    "Delete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Close();

            }
            else
            {
                if(IsTryToDeleteSelf)
                {
                    MessageBox.Show(
    $"You cannot delete your own {Mode} account.",
    "Delete Not Allowed",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        $"Unable to delete this {Mode} because it is linked to other records in the system.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SetRoles(int personId)
        {
            ucRoleAdmin.Visible = clsUsers.IsPersonAdmin(personId);
            ucRoleDoctor.Visible = clsUsers.IsPersonDoctor(personId);
            ucRolePatient.Visible = clsUsers.IsPersonPatient(personId);
        }

    }
}
