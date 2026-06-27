using Business_Layer;
using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Patients
{
    public partial class ucSamarySearch : UserControl
    {
        public event EventHandler OnFind;


        public enum Mode { Patient, Doctor }
        Mode _Mode;

        public Mode SearchMode
        {
            get { return _Mode; }

            set
            {
                _Mode = value;
                ChangeMode();
            }
        }

        clsPatients _Patinet;
        clsDoctors _Docotr;

        public int ID { get { return int.Parse(tbSearch.Text); } }

        public string Specialization { get { return _Docotr.Specialization.SpecializationName; } }




        public ucSamarySearch()
        {
            InitializeComponent();
        }

        void ChangeMode()
        {
            switch (_Mode)
            {
                case Mode.Patient:
                    _SetForPatient();
                    break;
                case Mode.Doctor:
                    _SetForDoctor();
                    break;
                default:
                    break;
            }
        }

        void _SetForPatient()
        {
            tbSearch.PlaceholderText = "PatientID...";
        }

        void _SetForDoctor()
        {
            lblOption.Text = "Specialization :";
            lblOption.Visible = true;
            lblValue.Visible = true;

            tbSearch.PlaceholderText = "DoctorID...";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (_Mode)
            {
                case Mode.Patient:
                    _SearchPatient();
                    break;
                case Mode.Doctor:
                    _SearchDoctor();
                    break;
                default:
                    break;
            }
        }


        void _SearchPatient()
        {
            if (tbSearch.Text != "")
            {
                _Patinet = clsPatients.Find(int.Parse(tbSearch.Text));

                if (_Patinet != null)
                {
                    SetData(_Patinet);
                    OnFind?.Invoke(this, EventArgs.Empty);
                }
                else
                {

                    MessageBox.Show(
    $"No Patient was found with ID = {tbSearch.Text}.",
    "Patient Not Found",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);
                }

            }

        }

        public void SetDataPatient(int PatientnID)
        {
            _Patinet = clsPatients.Find(int.Parse(tbSearch.Text));

            if (_Patinet != null)
            {
                SetData(_Patinet);
                OnFind?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SetData(clsPatients Patient)
        {
            tbSearch.Text = Patient.PatientID.ToString();

            _Patinet = Patient;

            lblName.Text = Patient.Person.FirstName + " " + Patient.Person.LastName;
            lblPhone.Text = Patient.Person.Phone;



            lblBloodType.Text = Patient.Person.BloodType.BloodName;

            clsActions.PfpPerfoum(ref pbPic, Patient.Person.ImagePath, Patient.Person.IsMale);


        }




        void _SearchDoctor()
        {
            if (tbSearch.Text != "")
            {
                _Docotr = clsDoctors.Find(int.Parse(tbSearch.Text));

                if (_Docotr != null)
                {
                    SetData(_Docotr);
                    OnFind?.Invoke(this, EventArgs.Empty);
                }
                else
                {

                    MessageBox.Show(
    $"No Doctor was found with ID = {tbSearch.Text}.",
    "Doctor Not Found",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);
                }

            }
        }

        public void SetDataDoctor(int DoctorID)
        {
            _Docotr = clsDoctors.Find(int.Parse(tbSearch.Text));

            if (_Docotr != null)
            {
                SetData(_Docotr);
                OnFind?.Invoke(this, EventArgs.Empty);
            }
        }

        public void SetData(clsDoctors Doctor)
        {
            tbSearch.Text = Doctor.DoctorID.ToString();

            _Docotr = Doctor;

            lblName.Text = "Dr." + Doctor.User.Person.FirstName + " " + Doctor.User.Person.LastName;
            lblPhone.Text = Doctor.User.Person.Phone;

            lblValue.Text = Doctor.Specialization.SpecializationName;

            lblBloodType.Text = Doctor.User.Person.BloodType.BloodName;

            clsActions.PfpPerfoum(ref pbPic, Doctor.User.Person.ImagePath, Doctor.User.Person.IsMale);


        }


        public void TurnOfSearch()
        {
            tbSearch.Enabled = false;
            btnSearch.Enabled = false;
        }

    }

}
