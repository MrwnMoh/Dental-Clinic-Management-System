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

namespace DCMS.Dhasboard.Totals
{
    public partial class ucMainSmalTotalCard : UserControl
    {

        public enum EDashboardCardType
        {
            Patients,
            TotalAppointments,
            Treatments,
            Revenue,
            Doctors,
            Admins,
            ActiveUsers,
            Users,
            TotalConfirmdAppointments,
            TotalCancelledAppointments,
            TotalPendingAppointments
        }

        private EDashboardCardType _cardType = EDashboardCardType.Patients;

        public EDashboardCardType CardType
        {
            get => _cardType;
            set
            {
                _cardType = value;
                _UpdateCardDesign();
            }
        }




        public ucMainSmalTotalCard()
        {
            InitializeComponent();
        }

        void _UpdateCardDesign()
        {
            switch (_cardType)
            {
                case EDashboardCardType.Patients:
                    _SetForPatients();
                    break;
                case EDashboardCardType.TotalAppointments:
                    _SetForAppointments();
                    break;
                case EDashboardCardType.Treatments:
                    _SetForTreatments();
                    break;
                case EDashboardCardType.Revenue:
                    _SetForRevenue();
                    break;
                    case EDashboardCardType.Doctors:
                        _SetForDoctors();
                    break;
                    case EDashboardCardType.Admins:
                        _SetForAdmins();
                    break;
                    case EDashboardCardType.ActiveUsers:
                        _SetForActiveUsers();
                    break;
                    case EDashboardCardType.Users:
                        _SetForUsers();
                    break;
                    case EDashboardCardType.TotalCancelledAppointments:
                    _SetForCancelled();
                    break;
                case EDashboardCardType.TotalPendingAppointments:
                    _SetForPending();
                    break;
                case EDashboardCardType.TotalConfirmdAppointments:
                    _SetForConfirmd();
                    break;
                default:
                    break;
            }
        }

        void _SetForPatients()
        {
            lblTotalOF.Text = "Patients";
            pbPic.Image = Resources.patient;

            lblCaption.Text = "All system Patients";
            lblCount.Text = clsStatistics.GetPatientsCount().ToString();
        }

        void _SetForAppointments()
        {
            lblTotalOF.Text = "Appointments";
            pbPic.Image = Resources.Appoinemts;

            lblCaption.Text = "Total Appointments";

            lblCount.Text = clsStatistics.GetTotalAppointments().ToString();

            lblCaption.Location = new Point(62, 101);

        }

        void _SetForTreatments()
        {
            lblTotalOF.Text = "Treatments";
            pbPic.Image = Resources.Treamnets;
            lblCaption.Text = "All Treatments";

            lblCount.Text = clsStatistics.GetTreatmentsCount().ToString();

        }

        void _SetForRevenue()
        {
            lblTotalOF.Text = "Revenue";
            pbPic.Image = Resources.Revenue;

            lblCaption.Text = "Total Revenue";

            lblCount.Text = clsStatistics.GetTotalRevenue().ToString("N2");

        }

        void _SetForDoctors()
        {
            lblTotalOF.Text = "Doctors";
            pbPic.Image = Resources.Doctors;
            lblCaption.Text = "Doctor accounts";
            lblCount.Text = clsStatistics.GetDoctorsCount().ToString();

        }

        void _SetForAdmins()
        {
            lblTotalOF.Text = "Admins";
            pbPic.Image = Resources.Admins;
            lblCaption.Text = "System administrators";

            lblCaption.Location = new Point(61, 101);
            lblCount.Text = clsStatistics.GetAdminsCount().ToString();

        }

        void _SetForActiveUsers()
        {
            lblTotalOF.Text = "Active Users";
            pbPic.Image = Resources.Actives;
            lblCaption.Text = "Currently active";
            lblCount.Text = clsStatistics.GetActiveUsersCount().ToString();

        }


        void _SetForUsers()
        {
            lblTotalOF.Text = "Users";
            pbPic.Image = Resources.Users;
            lblCaption.Text = "All system users";

            lblCount.Text = clsStatistics.GetUsersCount().ToString();


        }

        void _SetForCancelled()
        {
            lblTotalOF.Text = "Cancelled";
            pbPic.Image = Resources.close;
            lblCaption.Text = "Cancelled Appointments";

            lblCount.Text = clsStatistics.GetTotalCancelledAppointments().ToString();

            lblCaption.Location = new Point(36, 101);

        }

        void _SetForConfirmd()
        {
            lblTotalOF.Text = "Completed";
            pbPic.Image = Resources.check;
            lblCaption.Text = "Completed Appointments";

            lblCount.Text = clsStatistics.GetTotalConfirmdAppointments().ToString();

            lblCaption.Location = new Point(36, 101);

        }

        void _SetForPending()
        {
            lblTotalOF.Text = "Pending";
            pbPic.Image = Resources.load;
            lblCaption.Text = "Pending Appointments";

            lblCount.Text = clsStatistics.GetTotalPendingAppointments().ToString();

            lblCaption.Location = new Point(36, 101);

        }

        public void RefreshCounter()
        {
            _UpdateCardDesign();
        }

       
    }
}
