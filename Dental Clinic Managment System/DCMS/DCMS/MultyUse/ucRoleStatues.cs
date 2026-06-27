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

namespace DCMS.People
{
    public partial class ucRoleStatues : UserControl
    {
        public ucRoleStatues()
        {
            InitializeComponent();
        }

        public enum RoleType { Patient,Admin,Doctor,Pending,Cancelled,Completed};
        RoleType _Type;

        public int Statues {
            get
            {
                switch (_Type)
                {
                    case RoleType.Pending:
                        return 1;
                    case RoleType.Cancelled:
                        return 2;
                    case RoleType.Completed:
                        return 3;
                    default:
                        return 0;
                }
            }
        }


        public RoleType Type
        {
            get { return _Type; }
            set {
                _Type = value;
                SetRole();
                }
        }

        void SetRole()
        {
            switch (_Type)
            {
                case RoleType.Patient:
                    _SetForPatient();
                    break;
                case RoleType.Admin:
                    _SetForAdimn();
                    break;
                case RoleType.Doctor:
                    _SetForDoctor();
                    break;
                    case RoleType.Pending:
                        _SetForPending();
                    break;
                    case RoleType.Cancelled:
                        _SetForCancelled();
                    break;
                    case RoleType.Completed:
                        _SetForCompleted();
                    break;
                default:
                    break;
            }
        }

        void _SetForAdimn()
        {
            lblRole.Text = "Admin";
            lblRole.ForeColor = Color.FromArgb(15, 87, 253);
            plBackground.FillColor = Color.FromArgb(235, 243, 254);

            lblRole.Location = new Point(21, 9);

        }

        void _SetForDoctor()
        {
            lblRole.Text = "Doctor";
            lblRole.ForeColor = Color.FromArgb(106, 31, 252);
            plBackground.FillColor = Color.FromArgb(239, 233, 254);

            lblRole.Location = new Point(21, 9);

        }

        void _SetForPatient()
        {
            lblRole.Text = "Patient";
            lblRole.ForeColor = Color.FromArgb(110, 192, 154);
            plBackground.FillColor = Color.FromArgb(228, 248, 238);

            lblRole.Location = new Point(21, 9);

        }

        void _SetForPending()
        {
            lblRole.Text = "Pending";
            lblRole.ForeColor = Color.FromArgb(246, 142, 45);
            lblRole.Location = new Point(12, 9);
            plBackground.FillColor = Color.FromArgb(254, 246, 229);
        }

        void _SetForCancelled()
        {
            lblRole.Text = "Cancelled";
            lblRole.ForeColor = Color.Red;
            lblRole.Location = new Point(2, 9);
            plBackground.FillColor = Color.FromArgb(254, 233, 233);
        }

        void _SetForCompleted()
        {
            lblRole.Text = "Completed";
            lblRole.ForeColor = Color.FromArgb(93, 159, 115);
            lblRole.Location = new Point(-2, 9);
            plBackground.FillColor = Color.FromArgb(233, 248, 236);
        }
    }
}
