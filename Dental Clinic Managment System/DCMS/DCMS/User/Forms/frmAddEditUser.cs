using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.User.Forms
{
    public partial class frmAddEditUser : Form
    {

        bool IsFound = false;
        clsUsers _User;

        bool InEdit = false;

        public event EventHandler UserSaved;

        public frmAddEditUser(clsUsers User)
        {
            InitializeComponent();

            ucFilterDetailsWithSerch1.OnFindPerson += (s, e) =>
            {
                IsFound = true;
                btnNext.Enabled = true;
                OnFind();
            };

            ucFilterDetailsWithSerch1.TurnOfEdit();

            _User = User;
            LoadInfo();
        }

        void OnFind()
        {
            _User = clsUsers.FindByPersonID(ucFilterDetailsWithSerch1.PeronID);
            LoadInfo();
        }

        void LoadInfo()
        {
            if(_User == null)
            {
                _User = new clsUsers();
                return;
            }

            lblCaption.Text = "Edit User";

            lblUserID.Text = _User.UserID.ToString();
            tbUserName.Text = _User.Username;

            chkIsAdmin.Checked = _User.IsAdmin;
            chkIsActive.Checked = _User.IsActive;
            IsFound = true;
            btnNext.Enabled = true;
            tbCurrentPassword.Enabled = true;
            InEdit = true;

            ucFilterDetailsWithSerch1.SetData(_User.Person);
            ucFilterDetailsWithSerch1.TurnOfSearch();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(IsFound)
                TabControl.SelectedIndex = 1;

        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(!IsFound)
            {
                e.Cancel = true;
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if(Save())
            {
                UserSaved?.Invoke(this, EventArgs.Empty);
            }
        }

        bool Save()
        {
            if(CheckFeilds())
            {
                if(CheckPasswordMatch())
                {
                    _User.Username = tbUserName.Text;

                    if(tbNewPassword.Text != "")
                    _User.Password = clsUtil.HashingString(tbNewPassword.Text);
                   
                    _User.CreatedByID = clsSettings.CurrentUser.UserID;
                    _User.IsActive = chkIsActive.Checked;
                    _User.IsAdmin = chkIsAdmin.Checked;
                    _User.PersonID = ucFilterDetailsWithSerch1.PeronID;

                    if(_User.Save())
                    {
                        lblCaption.Text = "Edit User";
                        lblUserID.Text = _User.UserID.ToString() ;
                        btnAddNewUser.Enabled = false;
                        ucFilterDetailsWithSerch1.TurnOfSearch();



                        MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            return false;
        }

        bool CheckFeilds()
        {
            bool Go = true;

            if(tbUserName.Text == "")
            {
                errorProvider1.SetError(tbUserName, "Please enter your username");
                Go = false;
            }

            if(!InEdit)
            {
                if (tbNewPassword.Text == "")
                {
                    errorProvider1.SetError(tbNewPassword, "Please enter your Password");
                    Go = false;
                }
            }
            return Go;
        }

        bool CheckPasswordMatch()
        {
            if(!string.IsNullOrEmpty(tbNewPassword.Text) || !string.IsNullOrEmpty(tbConfirmPassword.Text))
            {
                if (tbNewPassword.Text != tbConfirmPassword.Text)
                {
                    errorProvider1.SetError(tbConfirmPassword, "Password is not match");
                    return false;
                }
                
            }

            if (InEdit)
            {
                if (clsUtil.HashingString(tbCurrentPassword.Text) != _User.Password)
                {
           errorProvider1.SetError(tbCurrentPassword, "Please enter the correct password");
                    return false;
                }
            }

            return true;
        }

        private void tbUserName_TextChanged(object sender, EventArgs e)
        {
            if(tbUserName.Text.Length > 0)
            {
                errorProvider1.SetError(tbUserName, "");
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbNewPassword.Text.Length > 0)
            {
                errorProvider1.SetError(tbNewPassword, "");
            }
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbConfirmPassword.Text.Length > 0)
            {
                errorProvider1.SetError(tbConfirmPassword, "");
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TabLoginInfo_Click(object sender, EventArgs e)
        {

        }

        private void tbCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbCurrentPassword.Text.Length > 0)
            {
                errorProvider1.SetError(tbCurrentPassword, "");
            }
        }

        private void chkIsActive_Click(object sender, EventArgs e)
        {
            if(InEdit)
            {
                if (clsSettings.CurrentUser.UserID == _User.UserID)
                    if (!chkIsActive.Checked)
                    {
                        errorProvider1.SetError(chkIsActive,"You cannot deactivate your own account.");
                        chkIsActive.Checked = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(chkIsActive, "");
                    }
            }
        }

        private void chkIsAdmin_Click(object sender, EventArgs e)
        {
            if (InEdit)
            {
                if (clsSettings.CurrentUser.UserID == _User.UserID)
                    if (!chkIsAdmin.Checked)
                    {
                        errorProvider1.SetError(chkIsAdmin, "You cannot remove yourself from the administrators.");
                        chkIsAdmin.Checked = true;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(chkIsAdmin, "");
                    }
            }

        }
    }
}
