using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using Business_Layer;
using System.IO;

namespace DCMS.People.Forms
{
    public partial class frmAddEditPerson : Form
    {

        clsPeople _Person;
        public event EventHandler PersonSaved;
        public  event EventHandler OnCurrentUserEdit;

        enum Mode { AddNew, Update};

        public frmAddEditPerson(clsPeople person)
        {
            InitializeComponent();


            chkGender.SelectedIndex = 0;

            LoadCountrys();
            LoadBloodTypes();

            _Person = person;
            LoadInfo();
        }

        


        void LoadInfo()
        {
            if(_Person == null)
            {
                _Person = new clsPeople();
                return;
            }

            lblCaption.Text = "Edit Person";

            tbID.Text = _Person.PersonID.ToString();
            tbFirstName.Text = _Person.FirstName;
            tbLastName.Text = _Person.LastName;   
            tbEmail.Text = _Person.Email;
            tbAddress.Text = _Person.Address;
            tbPhone.Text = _Person.Phone;

            chkBloodTypes.SelectedItem = _Person.BloodType.BloodName;
            chkCountrys.SelectedItem = _Person.Country.CountryName;
            chkGender.SelectedIndex = _Person.IsMale ? 0:1;

            dtpBirthDate.Value = _Person.BirthDate;

            //if (string.IsNullOrEmpty(ImagePath))
            //    SelectDefultPic();

            if (File.Exists(_Person.ImagePath))
            {
                pbPersonImage.ImageLocation = _Person.ImagePath;
                llblRemoveImage.Visible = true;
            }
            else
            {
                if (_Person.IsMale)
                {
                    pbPersonImage.Image = Resources.Boy;
                }
                else
                {
                    pbPersonImage.Image = Resources.Girl;
                }
            }
        }

        void LoadCountrys()
        {
            DataTable dt = clsCountrys.LoadAllCountrysNames();

            foreach(DataRow row in dt.Rows)
            {
                chkCountrys.Items.Add(row["Name"]);
            }
            chkCountrys.SelectedIndex = 49;

        }

        void LoadBloodTypes()
        {
            DataTable dt = clsBloodType.LoadAllBloodTypes();

            foreach (DataRow row in dt.Rows)
            {
                chkBloodTypes.Items.Add(row["BloodTypeName"]);
            }
            chkBloodTypes.SelectedIndex = 0;

        }


        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Image Files|*.png;*.jpg";
            openFileDialog1.DefaultExt = "png";


            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPersonImage.ImageLocation = openFileDialog1.FileName;
                llblRemoveImage.Visible = true;
            }    

        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblRemoveImage.Visible=false;
            pbPersonImage.ImageLocation = null;
            SelectDefultPic();
        }

        void SelectDefultPic()
        {
            
                if (chkGender.SelectedIndex == 0)
                {
                    pbPersonImage.Image = Resources.Boy;
                }
                else
                {
                    pbPersonImage.Image = Resources.Girl;
                }
           
        }

        private void chkGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pbPersonImage.ImageLocation))
                SelectDefultPic();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEamil_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbEmail.Text) && !IsValidEmail(tbEmail.Text))
            {
                errorProvider1.SetError(tbEmail, "Invalid Email");
                tbEmail.Focus();
            }
            else
                errorProvider1.SetError(tbEmail, "");
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var Add = new MailAddress(email);
                return Add.Address == email;
            }
            catch { return false; }
        }

        bool Save()
        {
            if(CheckFeailds())
            {
                if(_HandlePersonImage())
                {
                _Person.FirstName =tbFirstName.Text.Trim();
                _Person.LastName =tbLastName.Text.Trim();
                _Person.Email =tbEmail.Text.Trim();
                _Person.Address = tbAddress.Text.Trim();
                _Person.Phone =tbPhone.Text.Trim();
                _Person.ImagePath = pbPersonImage.ImageLocation;
                _Person.BirthDate = dtpBirthDate.Value;
                _Person.BloodTypeID = chkBloodTypes.SelectedIndex  + 1;
                _Person.CountryID = chkCountrys.SelectedIndex + 1;

                _Person.IsMale = chkGender.SelectedIndex == 0 ? true : false;
                    if (_Person.Save())
                    {
                        MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCaption.Text = "Edit Person";
                        PersonSaved?.Invoke(this, EventArgs.Empty);
                        return true;
                    }
                    else
                        MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        bool CheckFeailds()
        {
            bool Go = true;

            if(string.IsNullOrWhiteSpace(tbFirstName.Text))
            {
                errorProvider1.SetError(tbFirstName, "Please enter your first name");
                Go = false;
            }
            if (string.IsNullOrWhiteSpace(tbLastName.Text))
            {
                errorProvider1.SetError(tbLastName, "Please enter your last name");
                Go = false;
            }
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                errorProvider1.SetError(tbPhone, "Please enter your phone");
                Go = false;
            }
            if (string.IsNullOrWhiteSpace(tbAddress.Text))
            {
                errorProvider1.SetError(tbAddress, "Please enter your Address");
                Go = false;
            }

            return Go;
        }

        private bool _HandlePersonImage()
        {

            if (_Person.ImagePath != pbPersonImage.ImageLocation)
            {
                if (!string.IsNullOrEmpty( _Person.ImagePath))
                {

                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException)
                    {
                    }
                }

                if (pbPersonImage.ImageLocation != null)
                {
                    string SourceImageFile = pbPersonImage.ImageLocation.ToString();

                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
                    {
                        pbPersonImage.ImageLocation = SourceImageFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

            }
            return true;
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            if(Save())
            {
                if (_Person.PersonID == clsSettings.CurrentUser.PersonID)
                {
                    OnCurrentUserEdit?.Invoke(this, EventArgs.Empty);
                }

                tbID.Text = _Person.PersonID.ToString();
            }
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbFirstName, "");
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbLastName, "");
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPhone, "");
        }
    }
}
