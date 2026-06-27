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
using System.Xml.Linq;

namespace DCMS.People.Person
{
    public partial class ucPersonRow : UserControl
    {
        public delegate void OnClickOnTheRow(int PersonID);
        public event OnClickOnTheRow OnClick;

        public event EventHandler OnDeleteOrEdit;
        public event EventHandler OnCurrentUserEdit;


        int PersonID;

        public ucPersonRow(int ID, string FirstName, string LastName, string Phone, string Country, string BloodTypeName, string ImagePath, bool IsMale)
        {
            InitializeComponent();



            PersonID  = ID;
            lblPersonID.Text = ID.ToString();
            lblFullName.Text = FirstName + " " + LastName;
            lblPhone.Text = Phone;
            lblCountry.Text = Country;
            lblBloodType.Text = BloodTypeName;

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

            SetRoles(PersonID);
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

            OnClick?.Invoke(PersonID);

        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);

            if (!this.ClientRectangle.Contains(mousePos))
            {
                SetPanelColorToDefult();
            }
        }

        void SetRoles(int personId)
        {
            ucRoleAdmin.Visible = clsUsers.IsPersonAdmin(personId);
            ucRoleDoctor.Visible = clsUsers.IsPersonDoctor(personId);
            ucRolePatient.Visible = clsUsers.IsPersonPatient(personId);
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

        private void pnlGroupALL_MouseLeave(object sender, EventArgs e)
        {
            SetPanelColorToDefult();
        }

        private void ucPersonRow_MouseLeave(object sender, EventArgs e)
        {
            SetPanelColorToDefult();

        }

   

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            SetPanelColorToSelected();

        }


        private void guna2ContextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            SetPanelColorToDefult();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnDeleteOrEdit;
            clsActions.OnCurrentUserEdit += OnCurrentUserEdit;
            clsActions.EditPerson(PersonID);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnDeleteOrEdit;
            clsActions.DeletePerson(PersonID);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnDeleteOrEdit;
            clsActions.OnCurrentUserEdit += OnCurrentUserEdit;
            clsActions.ShowPersonDetails(PersonID);
        }
    }
}
