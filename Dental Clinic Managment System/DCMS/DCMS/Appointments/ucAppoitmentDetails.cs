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

namespace DCMS.Appointments
{
    public partial class ucAppoitmentDetails : UserControl
    {
        public ucAppoitmentDetails()
        {
            InitializeComponent();
        }

        public void LoadData(clsAppointments _Appointment)
        {


            tbNotes.Text = _Appointment.Notes;
            lblPrice.Text = _Appointment.Price.ToString();


            lblDateTime.Text = _Appointment.AppointmentDate.ToString();


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



    }
}
