using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Patients
{
    public partial class ucPatientRow : UserControl
    {


        int _ID;
        public event EventHandler Saved;

        public ucPatientRow(int PatientId,string FullName,string Phone,string BloodType,string ImagePath,bool IsMale)
        {
            InitializeComponent();

            _ID = PatientId;

            clsActions.PfpPerfoum(ref pbPic, ImagePath, IsMale);

            lblFullName.Text = FullName;
            lblPhone.Text = Phone;
            lblPatientID.Text = PatientId.ToString();
            lblBloodType.Text = BloodType.ToString();



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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                Saved?.Invoke(s, ee);
            }; clsActions.DeletePatient(_ID);
        }
    }
}
