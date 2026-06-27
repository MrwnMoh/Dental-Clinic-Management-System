using Business_Layer;
using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.User.Ucs
{
    public partial class ucSearchUser : UserControl
    {
        public event EventHandler OnFindUser;

        clsUsers User;


        public ucSearchUser()
        {
            InitializeComponent();
        }






        public int UserID
        {
            get { return int.Parse(tbSearch.Text);}
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            serach();
        }

        public void TurnOfSearch()
        {
            tbSearch.Enabled = false;
            btnSearch.Enabled = false;
        }

        void serach()
        {
            if (tbSearch.Text != "")
            {
                User = clsUsers.Find(int.Parse(tbSearch.Text));

                if (User != null)
                {
                    SetData(User);
                    OnFindUser?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                 
                    MessageBox.Show(
    $"No User was found with ID = {tbSearch.Text}.",
    "User Not Found",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);
                }

            }
        }

        public void SetData(int UserID)
        {
            tbSearch.Text = UserID.ToString();
            serach();
        }

        public void SetData(clsUsers _User)
        {
            User = _User;


            tbSearch.Text = User.UserID.ToString();


            lblName.Text = User.Person.FirstName + " " + User.Person.LastName;
            lblPhone.Text = User.Person.Phone;
            lblEmail.Text = User.Person.Email;
            lblAddress.Text = User.Person.Address;

            lblDateOfBirth.Text = User.Person.BirthDate.ToShortDateString();

            lblUsername.Text = User.Username;

            lblBloodType.Text = User.Person.BloodType.BloodName;

            lblGender.Text = User.Person.IsMale == true ? "Male" : "Female";

            lblCountry.Text = User.Person.Country.CountryName;

            if (!User.IsActive)
            {
                lblActive.Text = "Not Active";
                btnActiveationColor.FillColor = Color.Red;
                btnActiveationColor.FillColor2 = Color.IndianRed;
            }


            clsActions.PfpPerfoum(ref pbPic, User.Person.ImagePath, User.Person.IsMale);

            SetRoles(User.Person.PersonID);
        }

        void SetRoles(int personId)
        {
            ucRoleAdmin.Visible = clsUsers.IsPersonAdmin(personId);
            ucRoleDoctor.Visible = clsUsers.IsPersonDoctor(personId);
            ucRolePatient.Visible = clsUsers.IsPersonPatient(personId);
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
