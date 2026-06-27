using Business_Layer;
using DCMS.People.Forms;
using DCMS.People.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.People
{
    public partial class ucPeople : UserControl
    {
        DataView dv;
        DataTable dt;

        public event EventHandler OnRefresh;


        public event EventHandler OnCurrentUserEdit;

        int SelectedPerson = clsSettings.CurrentUser.PersonID;

        public ucPeople()
        {
            InitializeComponent();


            ucPersonInfoCard1.SetPersonDataByPersonID(SelectedPerson);
            dt = clsPeople.LoadAllPeople();
            dv = dt.DefaultView;
            ucBigTotalOf1.SetCount(dv.Count);
            LoadPeople();

            chkboxFilters.SelectedIndex = 0;
            chkBloodTypes.SelectedIndex = 0;

            ucPersonInfoCard1.OnDeleteOrEdit += (sender, e) =>
            {
                RefreshData(sender, e);
                SelectedPerson = clsSettings.CurrentUser.PersonID;
                ucPersonInfoCard1.SetPersonDataByPersonID(SelectedPerson);
                OnRefresh?.Invoke(sender, e);

            };


            ucPersonInfoCard1.OnCurrentUserEdit += (s,e) =>
            { OnCurrentUserEdit?.Invoke(s, e);
                    OnRefresh?.Invoke(s, e);
            };

        }

        void LoadPeople()
        {
            fpnlContater.Controls.Clear();

            
            foreach (DataRowView row in dv)
                {


                    int ID = (int)row["PersonID"];
                    string FirstName = (string)row["FirstName"];
                    string LastName = (string)row["LastName"];
                    bool IsMale = (bool)row["IsMale"];
                    string Phone = (string)row["Phone"];
                    string Country = (string)row["CountryName"];
                    string BloodTypeName = (string)row["BloodTypeName"];

                    string ImagePath = "";
                    if (row["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)row["ImagePath"];
                    }


                    ucPersonRow uc = new ucPersonRow(ID, FirstName, LastName, Phone, Country, BloodTypeName, ImagePath, IsMale);

                    uc.OnClick += OnRowClicked;

                
                uc.OnDeleteOrEdit += (sender, e) =>
                {
                    RefreshData(sender, e);
                    SelectedPerson = 1;
                    ucPersonInfoCard1.SetPersonDataByPersonID(SelectedPerson);
                    OnRefresh?.Invoke(sender, e);
                };

                uc.OnDeleteOrEdit += OnCurrentUserEdit;

                fpnlContater.Controls.Add(uc);
                }


        }

        void OnRowClicked(int personID)
        {

            SelectedPerson = personID;
            ucPersonInfoCard1.SetPersonDataByPersonID(personID);
        }


        public void RefreshData(object sender, EventArgs e)
        {
            dt = clsPeople.LoadAllPeople();
            dv = dt.DefaultView;
            LoadPeople();
            ucBigTotalOf1.SetCount(dv.Count);
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
                if(chkboxFilters.SelectedIndex == 5)
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
            if(chkboxFilters.SelectedIndex == 1 )
            {
                if(tbSearch.Text != "")
                dv.RowFilter = $"PersonID = {tbSearch.Text}";
                else
                    dv.RowFilter = "";

            }
            else if (chkboxFilters.SelectedIndex == 2)
            {
                dv.RowFilter = $"FirstName like '%{tbSearch.Text}%' or LastName like '%{tbSearch.Text}%'";
            }
            else if (chkboxFilters.SelectedIndex == 3)
            {
                dv.RowFilter = $"Phone like '%{tbSearch.Text}%'";
            }
            else if(chkboxFilters.SelectedIndex == 4)
            {
                dv.RowFilter = $"CountryName like '%{tbSearch.Text}%'";
            }

            LoadPeople();
        }

        private void chkBloodTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chkBloodTypes.SelectedIndex == 0)
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = $"BloodTypeName like '{chkBloodTypes.SelectedItem}'";
            }

            LoadPeople();
        }

        public void AddPerson()
        {
            frmAddEditPerson frm = new frmAddEditPerson(null);

            frm.PersonSaved += RefreshData;
            frm.ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson();
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(chkboxFilters.SelectedIndex == 1)
            {
                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
    
