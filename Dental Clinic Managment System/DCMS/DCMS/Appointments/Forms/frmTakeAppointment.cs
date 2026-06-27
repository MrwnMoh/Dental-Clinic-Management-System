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
    public partial class frmTakeAppointment : Form
    {

        public event EventHandler OnRefresh;


        DataTable dt;
        DataView dv ;

        List<string> _treatmentsNames = new List<string>();

        List<ucTreatentRow.RowArgs> _Treatments = new List<ucTreatentRow.RowArgs>();


        decimal TreatmentPrice;

        clsAppointments _Appointment;


        public frmTakeAppointment(int ID)
        {
            InitializeComponent();


            dt = clsTreatments.GetAllTreatments();
            dv = dt.DefaultView;
            LoadTreatments();

            _Appointment = clsAppointments.Find(ID);
            ucAppoitmentDetails1.LoadData(_Appointment);

            lblTotalAmount.Text = _Appointment.Price.ToString("N2");
            lblAppPrice.Text = _Appointment.Price.ToString("N2");

        }

        void UpdateUI()
        {
            lblTotalAmount.Text = (TreatmentPrice + _Appointment.Price).ToString("N2");
            lblSubTotal.Text = TreatmentPrice.ToString("N2");

            tbTreatments.Text = 
            string.Join(Environment.NewLine + "──────────────" + Environment.NewLine,_treatmentsNames);
        }

        void LoadTreatments()
        {

            foreach (DataRowView row in dv)
            {
                int TreatmentID = Convert.ToInt32(row["TreatmentID"]);

                string Name = row["Name"].ToString();

                string ImagePath = row["ImagePath"] == DBNull.Value
                    ? string.Empty
                    : row["ImagePath"].ToString();

                decimal Price = Convert.ToDecimal(row["Price"]);

                ucTreatentRow uc = new ucTreatentRow(TreatmentID, Name, ImagePath, Price);

                uc.OnTreatmentSelected += Uc_OnTreatmentSelected;
                uc.OnTreatmentDeSelected += Uc_OnTreatmentDeSelected;

                fpnlContater.Controls.Add(uc);
            }

        }

        private void Uc_OnTreatmentDeSelected(object sender, ucTreatentRow.RowArgs e)
        {
            TreatmentPrice -= e.Price;
            _treatmentsNames.Remove(e.Name);

            _Treatments.Remove(e);


            UpdateUI();

        }

        private void Uc_OnTreatmentSelected(object sender, ucTreatentRow.RowArgs e)
        {
            TreatmentPrice += e.Price;
            _treatmentsNames.Add(e.Name);

            _Treatments.Add(e);

            UpdateUI();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                MessageBox.Show(
                    "Appointment saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                OnRefresh?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(
                    "Failed to save the appointment. Please try again.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        bool Save()
        {

            if (SaveAllTreatements())
            {
                if(SavePayment())
                {
                    _Appointment.Status = clsAppointments.enAppointmentStatus.Completed;
                    if (_Appointment.Save())
                    {
                        btnSave.Enabled = false;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            return false;

        }

        bool SaveAllTreatements()
        {

            if (_Treatments.Count > 0)
            {
                foreach(var treatment in _Treatments)
                {
                    clsAppoimentTreatments AppT = new clsAppoimentTreatments();

                    AppT.UnitPrice = treatment.Price;
                    AppT.AppoimentID = _Appointment.AppointmentID;
                    AppT.TreatmenID = treatment.ID;

                    if(!AppT.Save())
                    {
                        return false;
                    }

                }

            }

           return true;
        }

        bool SavePayment()
        {
            clsPayment Pay = new clsPayment();
            Pay.AmountPaid = TreatmentPrice + _Appointment.Price;
            Pay.AppointmentID = _Appointment.AppointmentID;
            Pay.PaymentMethod = chkCash.Checked ? clsPayment.EPaymentMethod.Cash : clsPayment.EPaymentMethod.Card;

            if(!Pay.Save())
            {
                return false;
            }

            return true;
        }

    }
}
