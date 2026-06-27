using Business_Layer;
using DCMS.Dhasboard.Totals;
using DCMS.Doctors.Forms;
using DCMS.User.Ucs;
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
    public partial class ucDoctors : UserControl
    {
        bool CurrentUserIsDoctor = false;
        DataView dv;
        DataTable dt;
        public event EventHandler OnRefresh;


        public ucDoctors()
        {
            InitializeComponent();
            CheckCard();

            dt = clsDoctors.GetDoctorsDataWithDetails();
            dv = dt.DefaultView;

            LoadSpecializationsList();

            chkboxFilters.SelectedIndex = 0;

            LoadDoctors();
        }

        void LoadDoctors()
        {
            fpnlContater.Controls.Clear();

            bool Added = false;

            foreach (DataRowView row in dv)
            {


                int ID = (int)row["DoctorID"];
                string FullName = (string)row["FullName"];
                string SpecializationName = (string)row["SpecializationName"];
                bool IsMale = (bool)row["IsMale"];
                string Phone = (string)row["Phone"];

                string ImagePath = "";
                if (row["ImagePath"] != DBNull.Value)
                {
                    ImagePath = (string)row["ImagePath"];
                }


                ucDoctorRow uc = new ucDoctorRow(ID, FullName, SpecializationName, Phone, IsMale, ImagePath);

                //uc.OnSave += RefreshData;

                uc.OnRowClick += (s, id) => ucDoctorCard1.SetDataByDoctorID(id);
                //uc.de += (s, id) => ucDoctorCard1.SetDataByDoctorID(id);

                uc.OnSave += (s, e) =>
                {
                    RefreshData(s,e);
                    OnRefresh?.Invoke(this, EventArgs.Empty);
                };


                fpnlContater.Controls.Add(uc);


                if(!CurrentUserIsDoctor && !Added)
                {
                    Added = true;
                    ucDoctorCard1.SetDataByDoctorID(ID);
                }

            }


        }


        void LoadSpecializationsList()
        {
            DataTable dt = clsSpecialization.GetAllSpecializations();

            foreach (DataRow row in dt.Rows)
            {
                chkSpecization.Items.Add(row["Name"]);
            }
            chkSpecization.SelectedIndex = 0;
        }

        void CheckCard()
        {
            if(ucDoctorCard1.SetDataByUserID(clsSettings.CurrentUser.UserID))
            {
                CurrentUserIsDoctor = true;
            }
            else
                CurrentUserIsDoctor =false;

        }

        private void chkboxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkSpecization.Visible = false;

            dv.RowFilter = "";
            tbSearch.Text = string.Empty;

            if (chkboxFilters.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
                chkSpecization.SelectedIndex = 0;
            }
            else
            {
                if (chkboxFilters.SelectedIndex == 3)
                {
                    tbSearch.Visible = false;
                    chkSpecization.Visible = true;

                }
                else
                {
                    tbSearch.Visible = true;
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (chkboxFilters.SelectedIndex == 1)
            {
                if (tbSearch.Text != "")
                    dv.RowFilter = $"DoctorID = {tbSearch.Text}";
                else
                    dv.RowFilter = "";

            }
            else if (chkboxFilters.SelectedIndex == 2)
            {
                dv.RowFilter = $"FullName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 4)
            {
                dv.RowFilter = $"Phone like '%{tbSearch.Text}%'";
            }

            LoadDoctors();
        }

        private void chkSpecization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkSpecization.SelectedIndex == 0)
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"SpecializationName like '{chkSpecization.SelectedItem.ToString()}'";
            }

            LoadDoctors();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkboxFilters.SelectedIndex == 1)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        public void RefreshData(object sender, EventArgs e)
        {
            dt = clsDoctors.GetDoctorsDataWithDetails();
            dv = dt.DefaultView;

            LoadDoctors();
            

        }

        public void AddDoctor()
        {
            frmAddEditDoctor frm = new frmAddEditDoctor(null);

            frm.Saved += (ss, ee) =>
            {
                RefreshData(ss, ee);
                OnRefresh?.Invoke(this, EventArgs.Empty);
            };

            ucDoctorCard1.SetDataByUserID(clsSettings.CurrentUser.UserID);

            frm.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddDoctor();
        }
    }
}
