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

namespace DCMS.Doctors
{
    public partial class ucDoctorDetails : UserControl
    {
        public ucDoctorDetails()
        {
            InitializeComponent();

          


        }

        public void SetDetailsByDoctorID(int DoctorID)
        {
            clsDoctors Doctor = clsDoctors.Find(DoctorID);
            SetDetailsByDoctor(Doctor);
        }

        public void SetDetailsByDoctor(clsDoctors Doctor)
        {
                lblDoctorID.Text = Doctor.DoctorID.ToString();
                lblSpecialization.Text = Doctor.Specialization.SpecializationName.ToString();
        }
    }
}
