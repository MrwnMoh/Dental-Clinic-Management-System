using DCMS.Doctors.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Doctors
{
    public partial class ucDoctorRow : UserControl
    {

        public event EventHandler<int> OnRowClick;
        public event EventHandler OnSave;

        int _ID;

        public ucDoctorRow(int ID,string FullName,string SpecializationName,string Phone,bool IsMale,string ImagePath)
        {
            InitializeComponent();

            clsActions.PfpPerfoum(ref pbPic, ImagePath, IsMale);

            lblFullName.Text = FullName;
            lblPhone.Text = Phone;
            lblSpecializationName.Text = SpecializationName;
            lbDocID.Text = ID.ToString();

            _ID = ID;

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

            OnRowClick?.Invoke(this, _ID);
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
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.EditDoctor(_ID);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.DeleteDoctor(_ID);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.EditDoctor(_ID);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += OnSave;
            clsActions.DeleteDoctor(_ID);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoctorDetails frm = new frmDoctorDetails(_ID);

            frm.ShowDialog();
        }
    }
}
