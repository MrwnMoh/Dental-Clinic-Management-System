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
    public partial class frmLogin : Form
    {


        public frmLogin()
        {
            InitializeComponent();

            CheckReg();



        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string HashPasss = clsUtil.HashingString(tbPassword.Text);
            clsUsers User = clsUsers.FindByUsernameAndPassword(tbUserName.Text, HashPasss); 
            if (User != null)
            {
                if(!User.IsActive)
                {
                    MessageBox.Show(
                        "Your account is not active. Please contact the administrator.",
                        "Access Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if(!User.IsAdmin && !clsUsers.IsUserDoctor(User.UserID))
                {
                    MessageBox.Show(
    "Access denied. You must be a doctor or an administrator to log in.",
    "Login Failed",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                }

                clsSettings.CurrentUser = User;
                Form1 frm = new Form1(this);
                frm.Show();

                CheckRemamberME(User);

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid userName Or Password");
            }
        }


        void CheckRemamberME(clsUsers User)
        {
            if (chkRemember.Checked)
            {
                clsUtil.SaveUserEncInfoInWinReg(User.Username, tbPassword.Text);

            }
            else
            {
                clsUtil.DeleteUserInfoFromReg();
            }
        }

        void CheckReg()
        {
            string UserName = "";
            string Password = "";
            clsUtil.GetUserEncInfoInWinReg(ref UserName, ref Password);

            tbUserName.Text = UserName;
            tbPassword.Text = Password;

            if(tbUserName.Text.Length > 0)
            {
                chkRemember.Checked = true;
            }
        }
    }
}
