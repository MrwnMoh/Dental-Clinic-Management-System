using Business_Layer;
using DCMS.Appointments.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Appointments
{
    public partial class ucAppoimentRow : UserControl
    {
        public event EventHandler OnRefresh;

        int ID;

        bool IsCompleteORCanceld = true;

        public ucAppoimentRow(int AppointmentID, string PatientName, string PatientPhone, string PatientImagePath, bool PatientIsMale, string DoctorName, string DoctorPhone, string DoctorImagePath, bool DoctorIsMale, string Service, string Status, DateTime AppointmentDate)
        {
            InitializeComponent();

            ID = AppointmentID;

            lblID.Text = AppointmentID.ToString();

            lblFullNamePatient.Text = PatientName;
            lblPhonePatient.Text = PatientPhone;
            clsActions.PfpPerfoum(ref pbPicPatinet, PatientImagePath, PatientIsMale);


            lblFullNameDoctor.Text = DoctorName;
            lblPhoneDoctor.Text = DoctorPhone;
            clsActions.PfpPerfoum(ref pbPicDoctor, DoctorImagePath, DoctorIsMale);

            lblService.Text = Service;

            lblDate.Text = AppointmentDate.ToShortDateString() + " - " + AppointmentDate.ToShortTimeString() ;

            switch (Status)
            {
                case "Pending":
                    ucRoleStatues.Type = People.ucRoleStatues.RoleType.Pending;
                    IsCompleteORCanceld = false;
                    ToolDetails.Enabled = false;
                    break;
                case "Cancelled":
                    ucRoleStatues.Type = People.ucRoleStatues.RoleType.Cancelled;
                    btnEdit.Enabled = false;
                    ToolDetails.Enabled = false;
                    break;
                case "Completed":
                    ucRoleStatues.Type = People.ucRoleStatues.RoleType.Completed;
                    btnEdit.Enabled = false;
                    ToolDetails.Enabled = true;
                    break;

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
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                OnRefresh?.Invoke(this, ee);
            };

            clsActions.AddEditAppointment(ID);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                OnRefresh?.Invoke(this, ee);
            };

            clsActions.DeleteAppointment(ID);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTakeAppointment frm = new frmTakeAppointment(ID);

            frm.OnRefresh += (s, ee) =>
            {
                OnRefresh?.Invoke (this, ee);
            };

            frm.ShowDialog();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if(IsCompleteORCanceld)
            {
                tooolTakeApp.Enabled = false;
                toolCancel.Enabled = false;
                TooEdit.Enabled = false;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                OnRefresh?.Invoke(this, ee);
            };

            clsActions.DeleteAppointment(ID);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsActions.OnDeleteOrEdit += (s, ee) =>
            {
                OnRefresh?.Invoke(this, ee);
            };

            clsActions.AddEditAppointment(ID);
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(
    "Are you sure you want to cancel this appointment?",
    "Confirm Cancellation",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsAppointments.Cancel(ID))
                {
                    IsCompleteORCanceld = true;
                    MessageBox.Show(
    "The appointment has been cancelled successfully.",
    "Success",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);
                    OnRefresh?.Invoke(this, e);
                }
                else
                {
                    MessageBox.Show(
    "Failed to cancel the appointment.",
    "Cancellation Failed",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error);
                }
            }
        }

        private void ToolDetails_Click(object sender, EventArgs e)
        {
            frmAppoimentDetails frm = new frmAppoimentDetails(ID);
            frm.ShowDialog();
        }
    }
}
