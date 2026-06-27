using Business_Layer;
using DCMS.People.Person;
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
    public partial class frmAddEditDoctor : Form
    {

        clsDoctors __Doctor;
        bool IsFound = false;

        public event EventHandler Saved;


        public frmAddEditDoctor(clsDoctors Doctor)
        {
            InitializeComponent();

            LoadSpecialization();

            ucSearchUser1.OnFindUser += (s, e) =>
            {
                IsFound = true;
                btnNext.Enabled = true;
                OnFind();
            };

            __Doctor = Doctor;
            LoadInfo();

        }

        void LoadSpecialization()
        {
            DataTable dt = clsSpecialization.GetAllSpecializations();

            foreach (DataRow row in dt.Rows)
            {
                chkSpecialization.Items.Add(row["Name"]);
            }
            chkSpecialization.SelectedIndex = 0;

        }



        void OnFind()
        {
            __Doctor = clsDoctors.FindByUserID(ucSearchUser1.UserID);
            LoadInfo();
        }

        void LoadInfo()
        {
            if (__Doctor == null)
            {
                __Doctor = new clsDoctors();
                return;
            }

            lblCaption.Text = "Edit Doctor";

            lblDoctorID.Text = __Doctor.DoctorID.ToString();

            tbSalary.Text = __Doctor.Salary.ToString("N2");

            chkSpecialization.SelectedIndex = __Doctor.SpecializationID - 1;

            ucSearchUser1.TurnOfSearch();
            ucSearchUser1.SetData(__Doctor.User);


            IsFound = true;
            btnNext.Enabled =true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsFound)
                TabControl.SelectedIndex = 1;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Saved?.Invoke(this, EventArgs.Empty);
            }
        }

        bool Save()
        {
            if (CheckFeilds())
            {
                __Doctor.UserID  = ucSearchUser1.UserID;
                __Doctor.Salary = decimal.Parse(tbSalary.Text);
                __Doctor.HiringDate = DateTime.Now;
                __Doctor.SpecializationID = chkSpecialization.SelectedIndex + 1;

                    if (__Doctor.Save())
                    {
                        lblCaption.Text = "Edit Doctor";
                        lblDoctorID.Text = __Doctor.DoctorID.ToString();
                        btnAddNewUser.Enabled = false;
                        ucSearchUser1.TurnOfSearch();
                        MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                
            }

            return false;
        }

        bool CheckFeilds()
        {

            if (tbSalary.Text == "")
            {
                errorProvider1.SetError(tbSalary, "Please enter salary");
                return false;
            }

            return true;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;

        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!IsFound)
            {
                e.Cancel = true;
            }
        }

        private void tbSalary_Leave(object sender, EventArgs e)
        {
            tbSalary.Text = decimal.Parse(tbSalary.Text).ToString("N2");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
