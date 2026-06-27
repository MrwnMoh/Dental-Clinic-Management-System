using Business_Layer;
using DCMS.Dhasboard.Totals;
using DCMS.User.Ucs;
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

namespace DCMS.Patients
{
    public partial class ucPatients : UserControl
    {



        DataView dv;
        DataTable dt;

        public event EventHandler OnRefresh;


        public ucPatients()
        {
            InitializeComponent();


            dt = clsPatients.GetSummaryPatientData();
            dv = dt.DefaultView;

            ucBigTotalOf1.SetCount(dv.Count);

            LoadData();

            chkboxFilters.SelectedIndex = 0;
            chkBloodTypes.SelectedIndex = 0;

        }

        public void RefreshData(object sender, EventArgs e)
        {
            dt = clsPatients.GetSummaryPatientData();
            dv = dt.DefaultView;

            ucBigTotalOf1.SetCount(dv.Count);


            LoadData();
        }
        void LoadData()
        {
            fpnlContater.Controls.Clear();


            foreach (DataRowView row in dv)
            {


                int ID = (int)row["PatientID"];
                string FullName = (string)row["FullName"];
                string BloodTypeName = (string)row["BloodTypeName"];
                bool IsMale = (bool)row["IsMale"];
                string Phone = (string)row["Phone"];

                string ImagePath = "";
                if (row["ImagePath"] != DBNull.Value)
                {
                    ImagePath = (string)row["ImagePath"];
                }


                ucPatientRow uc = new ucPatientRow(ID, FullName, Phone, BloodTypeName, ImagePath,  IsMale);

                uc.Saved += (s, e) =>
                {
                    RefreshData(s, e);
                    OnRefresh?.Invoke(s, e);
                };

                fpnlContater.Controls.Add(uc);
            }


        }

        private void chkBloodTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBloodTypes.SelectedIndex == 0)
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"BloodTypeName like '{chkBloodTypes.SelectedItem}'";
            }

            LoadData();
        }

        private void chkboxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkBloodTypes.Visible = false;

            dv.RowFilter = "";
            tbSearch.Text = string.Empty;

            if (chkboxFilters.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
                chkBloodTypes.SelectedIndex = 0;
            }
            else
            {
                if (chkboxFilters.SelectedIndex == 4)
                {
                    tbSearch.Visible = false;
                    chkBloodTypes.Visible = true;

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
                    dv.RowFilter = $"PatientID = {tbSearch.Text}";
                else
                    dv.RowFilter = "";

            }
            else if (chkboxFilters.SelectedIndex == 2)
            {
                dv.RowFilter = $"FullName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 3)
            {
                dv.RowFilter = $"Phone like '%{tbSearch.Text}%'";
            }

            LoadData();
        }


        public void AddPatient()
        {
            clsActions.OnDeleteOrEdit += (ss, ee) =>
            {
                RefreshData(ss, ee);
                OnRefresh?.Invoke(this, EventArgs.Empty);
            };


            clsActions.AddPatient();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddPatient();

        }
    }
}
