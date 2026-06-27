using Business_Layer;
using DCMS.People.Forms;
using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.People
{
    public partial class ucPersonInfoCard : UserControl
    {
        clsPeople _Person;
        public event EventHandler OnDeleteOrEdit;
        public event EventHandler OnCurrentUserEdit;


        public ucPersonInfoCard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }


        public void SetPersonDataByPersonID(int  personID)
        {
           
            _Person = clsPeople.Find(personID);

            if(_Person == null)
            {
                SetWrongInfo();
                return;
            }

            lblName.Text = _Person.FirstName + " " + _Person.LastName;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;

            lblDateOfBirth.Text = _Person.BirthDate.ToShortDateString();

            
            lblBloodType.Text = _Person.BloodType.BloodName;

            lblGender.Text = _Person.IsMale == true ? "Male" : "Female";

            lblCountry.Text = _Person.Country.CountryName;

            clsActions.PfpPerfoum(ref pbPic, _Person.ImagePath, _Person.IsMale);

            

            SetRoles(personID);

        }


        void SetWrongInfo()
        {
            foreach(Control ctrl in gpAll.Controls)
            {
                if(ctrl is Label)
                {
                    ctrl.Text = "Wrong Info";
                }
            }

        }

        void SetRoles(int personId)
        {
            ucRoleAdmin.Visible = clsUsers.IsPersonAdmin(personId);
            ucRoleDoctor.Visible = clsUsers.IsPersonDoctor(personId);
            ucRolePatient.Visible = clsUsers.IsPersonPatient(personId);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            clsActions.OnDeleteOrEdit += OnDeleteOrEdit;

            clsActions.OnCurrentUserEdit += (s,ev) => { OnCurrentUserEdit?.Invoke(s, ev); };

            clsActions.EditPerson(_Person);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnDeleteOrEdit;
            clsActions.DeletePerson(_Person.PersonID);
        }



    }
}
