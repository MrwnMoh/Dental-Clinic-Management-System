using Business_Layer;
using DCMS.Patients;
using DCMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Appointments
{
    public partial class ucAppointments : UserControl
    {
        DataView dv;
        DataTable dt;

        public event EventHandler OnRefresh;


        public ucAppointments()
        {
            InitializeComponent();


            dt = clsAppointments.GetAppointmentsSummary();
            dv = dt.DefaultView;

            chkboxFilters.SelectedIndex = 0; 
            LoadData();
            LoadSpecializationsList();

        }

        public void RefreshData(object sender, EventArgs e)
        {
            dt = clsAppointments.GetAppointmentsSummary();
            dv = dt.DefaultView;

            ucMainSmalTotalCard4.RefreshCounter();
            ucMainSmalTotalCard5.RefreshCounter();
            ucMainSmalTotalCard6.RefreshCounter();
            ucMainSmalTotalCard7.RefreshCounter();

            LoadData();
        }

        void LoadData()
        {
            fpnlContater.Controls.Clear();

            foreach (DataRowView row in dv)
            {
                int AppointmentID = Convert.ToInt32(row["AppointmentID"]);

                string PatientName = row["PatientName"].ToString();
                string PatientPhone = row["PatientPhone"].ToString();

                string PatientImagePath = row["PatientImagePath"] == DBNull.Value
                    ? string.Empty
                    : row["PatientImagePath"].ToString();

                bool PatientIsMale = Convert.ToBoolean(row["PatientIsMale"]);

                string DoctorName = row["DoctorName"].ToString();
                string DoctorPhone = row["DoctorPhone"].ToString();

                string DoctorImagePath = row["DoctorImagePath"] == DBNull.Value
                    ? string.Empty
                    : row["DoctorImagePath"].ToString();

                bool DoctorIsMale = Convert.ToBoolean(row["DoctorIsMale"]);

                string Service = row["Service"].ToString();
                string Status = row["Status"].ToString();

                DateTime AppointmentDate = Convert.ToDateTime(row["AppointmentDate"]);

                ucAppoimentRow uc = new ucAppoimentRow(
                    AppointmentID,
                    PatientName,
                    PatientPhone,
                    PatientImagePath,
                    PatientIsMale,
                    DoctorName,
                    DoctorPhone,
                    DoctorImagePath,
                    DoctorIsMale,
                    Service,
                    Status,
                    AppointmentDate);

                uc.OnRefresh += (s, ee) =>
                {
                    RefreshData(s, ee);
                    OnRefresh?.Invoke(this, ee);
                };

                fpnlContater.Controls.Add(uc);
            }
        }

        public void AddAppointment()
        {
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                RefreshData(s, ee);
                OnRefresh?.Invoke(this, ee);
            };

            clsActions.AddEditAppointment(null);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddAppointment();
        }

        private void chkboxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkService.Visible = false;

            dv.RowFilter = "";
            tbSearch.Text = string.Empty;

            if (chkboxFilters.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
                chkService.SelectedIndex = 0;
            }
            else
            {
                if (chkboxFilters.SelectedIndex == 4)
                {
                    tbSearch.Visible = false;
                    chkService.Visible = true;

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
                    dv.RowFilter = $"AppointmentID = {tbSearch.Text}";
                else
                    dv.RowFilter = "";

            }
            else if (chkboxFilters.SelectedIndex == 2)
            {
                dv.RowFilter = $"PatientName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 4)
            {
                dv.RowFilter = $"DoctorName like '%{tbSearch.Text}'";
            }

            LoadData();
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

        private void chkService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkService.SelectedIndex == 0)
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"Service like '{chkService.SelectedItem.ToString()}'";
            }

            LoadData();
        }
        void LoadSpecializationsList()
        {
            DataTable dt = clsSpecialization.GetAllSpecializations();

            foreach (DataRow row in dt.Rows)
            {
                chkService.Items.Add(row["Name"]);
            }
            chkService.SelectedIndex = 0;
        }


    }
}
