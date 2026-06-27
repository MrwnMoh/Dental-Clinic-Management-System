using Business_Layer;
using DCMS.Properties;
using DCMS.User.Forms;
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

namespace DCMS.User.Ucs
{
    public partial class ucUserRow : UserControl
    {
        int _UserID;

        public event EventHandler OnSave;

        public ucUserRow(int UserId,string FullName,string Phone,string UserName,string ImagePath,bool IsActive,bool IsMale,bool IsAdmin)
        {
            InitializeComponent();

            _UserID = UserId;

            lblUserID.Text = UserId.ToString();
            lblFullName.Text = FullName;
            lblPhone.Text = Phone;
            lblUserName.Text = UserName;    

            if(!IsActive )
            {
                lblActive.Text = "Not Active";
                btnActiveationColor.FillColor = Color.Red;
                btnActiveationColor.FillColor2 = Color.IndianRed;
            }

            if(IsAdmin)
            {
                ucRoleAdmin.Visible = true;
            }
            if(clsUsers.IsUserDoctor(UserId))
            {
                ucRoleDoctor.Visible = true;
            }

            if (File.Exists(ImagePath))
            {
                pbPic.ImageLocation = ImagePath;
            }
            else
            {
                if (IsMale)
                {
                    pbPic.Image = Resources.Boy;
                }
                else
                {
                    pbPic.Image = Resources.Girl;
                }
            }

            RegisterHoverEvents(this);

        }


        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += Control_MouseEnter;
            parent.MouseLeave += Control_MouseLeave;
            parent.Click += Control_MouseClick;

            foreach (Control c in parent.Controls)
            {
                RegisterHoverEvents(c);
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            SetPanelColorToOnEnter();
        }

        private void Control_MouseClick(object sender, EventArgs e)
        {
            SetPanelColorToSelected();
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);

            if (!this.ClientRectangle.Contains(mousePos))
            {
                SetPanelColorToDefult();
            }
        }


        void SetPanelColorToOnEnter()
        {
            pnlGroupALL.FillColor = Color.FromArgb(235, 243, 254);
        }

        void SetPanelColorToDefult()
        {
            pnlGroupALL.FillColor = Color.Transparent;
        }

        void SetPanelColorToSelected()
        {
            pnlGroupALL.FillColor = Color.FromArgb(210, 228, 254);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetPanelColorToSelected();
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.EditUser(_UserID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.DeleteUser(_UserID);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetPanelColorToSelected();
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.EditUser(_UserID);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.DeleteUser(_UserID);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserDetails frm = new frmUserDetails(_UserID);
            frm.ShowDialog();
        }
    }
}
