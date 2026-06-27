using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Doctors
{
    public partial class ucDoctorCard : UserControl
    {
        public event EventHandler OnSave;

        clsDoctors _Doctor;

        public ucDoctorCard()
        {
            InitializeComponent();
        }

        public bool SetDataByUserID(int UserID)
        {
            if(clsUsers.IsUserDoctor(UserID))
            {
                clsDoctors Docotr = clsDoctors.FindByUserID(UserID);
                if(Docotr != null)
                {
                    SetDataByDocotr(Docotr);
                    return true;
                }

            }
            return false;
        }

        public void SetDataByDoctorID(int ID)
        {
            clsDoctors Doctor = clsDoctors.Find(ID);
            if (Doctor != null)
            {
                SetDataByDocotr(Doctor);
            }
        }
       
        public void SetDataByDocotr(clsDoctors Doctor)
        {
            _Doctor = Doctor;
            clsActions.PfpPerfoum(ref pbPic, Doctor.User.Person.ImagePath, Doctor.User.Person.IsMale);

            lblBloodType.Text = Doctor.User.Person.BloodType.BloodName;

            lblHiringDate.Text = Doctor.HiringDate.ToShortDateString();

            if(Doctor.LeaveDate.HasValue)
            {
                lbleaveDate.Text = Doctor.LeaveDate.Value.ToShortDateString();
            }
            else
            {
                lbleaveDate.Text = "N/A";
            }

            if (!Doctor.User.IsActive)
            {
                lblActive.Text = "Not Active";
                btnActiveationColor.FillColor = Color.Red;
                btnActiveationColor.FillColor2 = Color.IndianRed;
            }

            lblFullName.Text = "Dr." + Doctor.User.Person.FirstName + " " + Doctor.User.Person.LastName;

            lblSpecialization.Text = Doctor.Specialization.SpecializationName;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.EditDoctor(_Doctor);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.DeleteDoctor(_Doctor.DoctorID);
        }
    }
}
