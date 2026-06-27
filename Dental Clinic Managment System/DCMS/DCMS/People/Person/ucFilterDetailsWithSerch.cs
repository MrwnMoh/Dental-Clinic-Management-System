using Business_Layer;
using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.People.Person
{
    public partial class ucFilterDetailsWithSerch : UserControl
    {
        public EventHandler OnEdit;
        public event EventHandler OnCurrentUserEdit;
        clsPeople Person;

        public int PeronID
        { get { return Person.PersonID; } }

        bool OfEdit = false;

        public event EventHandler OnFindPerson;


        public ucFilterDetailsWithSerch()
        {
            InitializeComponent();
        }

       public void TurnOfSearch()
        {
            tbSearch.Enabled = false;
            btnSearch.Enabled = false;
            OfEdit = true;
        }

        public void TurnOfEdit()
        {
            OfEdit = true;
            llblREdit.Enabled = false;
        }


        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            serach();
        }

        void serach()
        {
            if (tbSearch.Text != "")
            {
                Person = clsPeople.Find(int.Parse(tbSearch.Text));

                if (Person != null)
                {
                    SetData(Person);
                    OnFindPerson?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    if(OfEdit)
                    llblREdit.Visible = false;
                    MessageBox.Show(
    $"No person was found with ID = {tbSearch.Text}.",
    "Person Not Found",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);
                }

            }
        }

        public void SetData(int PersonID)
        {
            Person = clsPeople.Find(int.Parse(tbSearch.Text));

            if (Person != null)
            {
                SetData(Person);
                OnFindPerson?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SetData(clsPeople _Person)
        {
            if (!OfEdit)
                llblREdit.Visible = true;

            tbSearch.Text = _Person.PersonID.ToString();

            Person = _Person;

            lblName.Text = _Person.FirstName + " " + _Person.LastName;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;

            lblDateOfBirth.Text = _Person.BirthDate.ToShortDateString();


            lblBloodType.Text = _Person.BloodType.BloodName;

            lblGender.Text = _Person.IsMale == true ? "Male" : "Female";

            lblCountry.Text = _Person.Country.CountryName;

            if (File.Exists(_Person.ImagePath))
            {
                pbPic.ImageLocation = null;
                pbPic.ImageLocation = _Person.ImagePath;
            }
            else
            {
                if (_Person.IsMale)
                {
                    pbPic.Image = Resources.Boy;
                }
                else
                {
                    pbPic.Image = Resources.Girl;
                }
            }

            SetRoles(_Person.PersonID);
        }

        void SetRoles(int personId)
        {
            ucRoleAdmin.Visible = clsUsers.IsPersonAdmin(personId);
            ucRoleDoctor.Visible = clsUsers.IsPersonDoctor(personId);
            ucRolePatient.Visible = clsUsers.IsPersonPatient(personId);
        }

        private void llblREdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            clsActions.OnDeleteOrEdit += (s, ev) =>
            {
                serach();
                OnEdit?.Invoke(this, ev);
            };

            clsActions.OnCurrentUserEdit += (s, ev) =>
            {
                serach();
                OnCurrentUserEdit?.Invoke(this, ev);
            };


            clsActions.EditPerson(Person);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
