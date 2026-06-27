using Business_Layer;
using DCMS.Treatmets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Appointments.Forms
{
    public partial class frmAppoimentDetails : Form
    {
        DataTable dt;
        DataView dv;


        clsAppointments _Appointment;
        clsPayment _Payment;

        public frmAppoimentDetails(int AppID)
        {
            InitializeComponent();



            _Appointment = clsAppointments.Find(AppID);
            ucAppoitmentDetails1.LoadData(_Appointment);

            SetPayment();

            LoadTreatments();

        }

        void SetPayment()
        {
            _Payment = clsPayment.FindByAppointmentID(_Appointment.AppointmentID);

            if (_Payment == null)
                return;

            lblDate.Text = _Payment.PaymentDate.ToString();
            lblTotalAmount.Text = _Payment.AmountPaid.ToString("N2");

            if (_Payment.PaymentMethod == clsPayment.EPaymentMethod.Card)
            {
                chkCard.Checked = true;
                chkCash.Checked = false;
            }

        }

        void LoadTreatments()
        {
            dt = clsAppointments.GetAppointmentTreatments(_Appointment.AppointmentID);
            dv = dt.DefaultView;

            foreach (DataRowView row in dv)
            {
                int TreatmentID = Convert.ToInt32(row["TreatmentID"]);

                string Name = row["Name"].ToString();

                string ImagePath = row["ImagePath"] == DBNull.Value
                    ? string.Empty
                    : row["ImagePath"].ToString();

                decimal Price = Convert.ToDecimal(row["Price"]);

                ucTreatentRow uc = new ucTreatentRow(TreatmentID, Name, ImagePath, Price);
                uc.chkSelected.Checked = true;

                fpnlContater.Controls.Add(uc);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
