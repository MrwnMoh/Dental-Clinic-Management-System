using Business_Layer;
using DCMS.People.Person;
using DCMS.User.Forms;
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

namespace DCMS.Users
{
    public partial class ucUsers : UserControl
    {

        DataView dv;
        DataTable dt;


        public event EventHandler OnRefresh;


        public ucUsers()
        {
            InitializeComponent();


            dt = clsUsers.GetAllUsersInfoWithPeople();
            dv = dt.DefaultView;


            
            LoadPeople();

            chkboxFilters.SelectedIndex = 0;
            chkActivation.SelectedIndex = 0;

        }

        void LoadPeople()
        {
            fpnlContater.Controls.Clear();


            foreach (DataRowView row in dv)
            {


                int ID = (int)row["UserID"];
                string FullName = (string)row["FullName"];
                string UserName = (string)row["Username"];
                bool IsMale = (bool)row["IsMale"];
                bool IsActive = (bool)row["IsActive"];
                bool IsAdmin = (bool)row["IsAdmin"];
                string Phone = (string)row["Phone"];

                string ImagePath = "";
                if (row["ImagePath"] != DBNull.Value)
                {
                    ImagePath = (string)row["ImagePath"];
                }


                ucUserRow uc = new ucUserRow(ID, FullName, Phone, UserName, ImagePath, IsActive, IsMale, IsAdmin);

                uc.OnSave += RefreshData;
                uc.OnSave += OnRefresh;

                fpnlContater.Controls.Add(uc);
            }


        }

        private void chkActivation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkActivation.SelectedIndex == 0)
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"IsActive = {(chkActivation.SelectedIndex == 1? 1 : 0)}";
            }

            LoadPeople();
        }

        private void chkboxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkActivation.Visible = false;

            dv.RowFilter = "";
            tbSearch.Text = string.Empty;

            if (chkboxFilters.SelectedIndex == 0)
            {
                tbSearch.Visible = false;
                chkActivation.SelectedIndex = 0;
            }
            else
            {
                if (chkboxFilters.SelectedIndex == 5)
                {
                    tbSearch.Visible = false;
                    chkActivation.Visible = true;

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
                    dv.RowFilter = $"UserID = {tbSearch.Text}";
                else
                    dv.RowFilter = "";

            }
            else if (chkboxFilters.SelectedIndex == 2)
            {
                dv.RowFilter = $"FullName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 3)
            {
                dv.RowFilter = $"UserName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 4)
            {
                dv.RowFilter = $"Phone like '%{tbSearch.Text}%'";
            }

            LoadPeople();
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

        public void AddUser()
        {
            clsActions.OnDeleteOrEdit += RefreshData;
            clsActions.EditUser(null);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }


        public void RefreshData(object sender, EventArgs e)
        {
            dt = clsUsers.GetAllUsersInfoWithPeople();
            dv = dt.DefaultView;
            ucMainSmalTotalCard4.RefreshCounter();
            ucMainSmalTotalCard5.RefreshCounter();
            ucMainSmalTotalCard6.RefreshCounter();
            ucMainSmalTotalCard7.RefreshCounter();
            LoadPeople();
        }

    }
}
