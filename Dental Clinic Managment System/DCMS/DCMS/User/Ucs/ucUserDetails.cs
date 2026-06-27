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

namespace DCMS.User.Ucs
{
    public partial class ucUserDetails : UserControl
    {
        public ucUserDetails()
        {
            InitializeComponent();
        }

        public void SetData(int UserID)
        {
            clsUsers User = clsUsers.Find(UserID);

            if(User == null)
            {
                return;
            }

            SetData(User);

        }

        public void SetData(clsUsers User)
        {
            lblUserID.Text = User.UserID.ToString();
            lblCreatedAt.Text = User.CreatedAt.ToString();

            lnlUsername.Text = User.Username;

            if (User.CreatedByID != -1)
                lblCreatedBy.Text = clsUsers.GetUsernameByUserID(User.CreatedByID);
            else
            {
                lblCreatedBy.Text = "N/A";
            }

            if (!User.IsAdmin)
                lblIsAdmin.Text = "No";

        }


    }
}
