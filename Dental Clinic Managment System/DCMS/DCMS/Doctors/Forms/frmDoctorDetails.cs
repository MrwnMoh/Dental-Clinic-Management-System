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

namespace DCMS.Doctors.Forms
{
    public partial class frmDoctorDetails : Form
    {
        public frmDoctorDetails(int DoctorID)
        {
            InitializeComponent();


            clsDoctors Doctor = clsDoctors.Find(DoctorID);
            if (Doctor != null)
            {
                ucFilterDetailsWithSerch1.SetData(Doctor.User.Person);
                ucFilterDetailsWithSerch1.TurnOfSearch();
                ucUserDetails1.SetData(Doctor.User);
                ucFilterDetailsWithSerch1.TurnOfEdit();
                ucDoctorDetails1.SetDetailsByDoctor(Doctor);
            }



        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
