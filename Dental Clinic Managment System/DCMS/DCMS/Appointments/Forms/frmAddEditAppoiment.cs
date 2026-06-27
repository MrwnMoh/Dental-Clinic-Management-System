using Business_Layer;
using DCMS.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Business_Layer.clsAppointments;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DCMS.Appointments.Forms
{
    public partial class frmAddEditAppoiment : Form
    {
        public event EventHandler Saved;

        clsAppointments _Appointment;

        DateTime AppoimentDate;


        int PatientID;
        int DoctorID;


        string Specialization;

        public frmAddEditAppoiment(clsAppointments appointment)
        {
            InitializeComponent();

            PatientID = -1;
            DoctorID = -1;

            _Appointment = appointment;

            LoadData();

            dptAppoimentDate.Format = DateTimePickerFormat.Custom;
            dptAppoimentDate.CustomFormat = "dd/MM/yyyy hh:mm tt";


            AppoimentDate = dptAppoimentDate.Value;
            UpdateAppointmentDateTime();



            ucSamarySearchPatient.OnFind += (s, e) =>
            {
                PatientID = ucSamarySearchPatient.ID;


                lblPatinetID.Text = PatientID.ToString();

                errorProvider1.SetError(ucSamarySearchPatient, "");

            };

            ucSamarySearchDoctor.OnFind += (s, e) =>
            {
                DoctorID = ucSamarySearchDoctor.ID;
                Specialization = ucSamarySearchDoctor.Specialization;

                lblDoctorID.Text = DoctorID.ToString();
                lblSpecialization.Text = Specialization;

                errorProvider1.SetError(ucSamarySearchDoctor, "");
            };


        }

        void LoadData()
        {
            if(_Appointment == null)
            {
                _Appointment = new clsAppointments();
                return;
            }


            tbNotes.Text = _Appointment.Notes;
            tbPrice.Text = _Appointment.Price.ToString();

            lblCaption.Text = "Edit Appointment";
            lblDoctorID.Text = _Appointment.DoctorID.ToString();
            lblPatinetID.Text= _Appointment.PatientID.ToString();

            PatientID = _Appointment.PatientID;
            DoctorID = _Appointment.DoctorID;

            lblSelectedDateTime.Text = _Appointment.AppointmentDate.ToString();

            nudHours.Value = _Appointment.AppointmentDate.Hour;
            nudMinutes.Value = _Appointment.AppointmentDate.Minute;

            lblSpecialization.Text = _Appointment.Doctor.Specialization.SpecializationName;

            switch (_Appointment.Status)
            {
                case enAppointmentStatus.Pending:
                     ucRoleStatues1.Type = ucRoleStatues.RoleType.Pending;
                    break;
                case enAppointmentStatus.Cancelled:
                    ucRoleStatues1.Type = ucRoleStatues.RoleType.Cancelled;
                    break;
                case enAppointmentStatus.Completed:
                    ucRoleStatues1.Type = ucRoleStatues.RoleType.Completed;
                    break;
            }

            ucSamarySearchDoctor.SetData(_Appointment.Doctor);

            ucSamarySearchPatient.SetData(_Appointment.Patient);

            ucSamarySearchDoctor.TurnOfSearch();
            ucSamarySearchPatient.TurnOfSearch();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Save())
            {
                Saved?.Invoke(this, EventArgs.Empty);
            }
        }

        bool Save()
        {

            if(CheckFounds())
            {
                if(CheckFeilds())
                {

                    _Appointment.Price = decimal.Parse(tbPrice.Text);
                    _Appointment.AppointmentDate = AppoimentDate;
                    _Appointment.Notes = tbNotes.Text;
                    _Appointment.PatientID = PatientID;
                    _Appointment.DoctorID = DoctorID;
                    _Appointment.Status = (clsAppointments.enAppointmentStatus)ucRoleStatues1.Statues;

                    if(_Appointment.Save())
                    {
                        btnSave.Enabled = false;
                        tbNotes.Enabled = false;
                        tbPrice.Enabled = false;
                        nudHours.Enabled = false;
                        nudMinutes.Enabled = false;
                        dptAppoimentDate.Enabled = false;

                        ucSamarySearchDoctor.TurnOfSearch();
                        ucSamarySearchPatient.TurnOfSearch();


                        return true;
                    }
                    


                }
            }

            return false;
        }

        bool CheckFeilds()
        {
            if (tbPrice.Text == "")
            {
                errorProvider1.SetError(tbPrice, "Enter the price");
                return false;
            }
            return true;
        }

        bool CheckFounds()
        {
            bool Go = true;

            if(PatientID == -1)
            {
                errorProvider1.SetError(ucSamarySearchPatient, "Please select a patient first");
                Go = false;
            }

            if (DoctorID == -1)
            {
                errorProvider1.SetError(ucSamarySearchDoctor, "Please select a Docotr first");
                Go = false;
            }

            return Go;

        }

        private void tbSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void nudMinutes_ValueChanged(object sender, EventArgs e)
        {
            UpdateAppointmentDateTime();

        }

        private void UpdateAppointmentDateTime()
        {
            AppoimentDate = dptAppoimentDate.Value.AddHours((int)nudHours.Value).AddMinutes((int)nudMinutes.Value);
            lblSelectedDateTime.Text = AppoimentDate.ToString();
        }

        private void nudHours_ValueChanged(object sender, EventArgs e)
        {
            UpdateAppointmentDateTime();
        }

        private void dptAppoimentDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateAppointmentDateTime();

        }

        private void tbSalary_Leave(object sender, EventArgs e)
        {
            tbPrice.Text = decimal.Parse(tbPrice.Text).ToString("N2");
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbPrice, "");
        }
    }
}
