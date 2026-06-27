using Business_Layer;
using DCMS.Appointments;
using DCMS.Dhasboard;
using DCMS.Doctors;
using DCMS.Patients;
using DCMS.People;
using DCMS.Properties;
using DCMS.User.Forms;
using DCMS.Users;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DCMS
{
    public partial class Form1 : Form
    {

        enum enSidebar { Dashboard , Patients, People , Users , Doctors , Appointments };
        enSidebar _eSidebar = enSidebar.Dashboard;

        Guna2GradientButton CurrentButton;

        bool Logout = false;

        frmLogin _Login;

        static class clsSidebarColors
        {
            static public Color ActiveFill_1 = Color.FromArgb(20, 110, 252);
            static public Color ActiveFill_2 = Color.FromArgb(13, 106, 253);
            static public Color ActiveTextColor = Color.White;

            static public Color DisableFill = Color.White;
            static public Color DisableTextColor = Color.FromArgb(44, 48, 73);


        }

        public static class clsSlidebarOptiones
        {
            public static ucDashboard Dashboard ;

            public static ucPeople People;

            public static ucUsers Users;

            public static ucDoctors Doctors;

            public static ucPatients Patients;

            public static ucAppointments Appointments;


            public static void OpenDashboard(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(Dashboard);
            }

            public static void OpenPeople(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(People);
            }

            public static void OpenUsers(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(Users);
            }

            public static void OpenDoctors(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(Doctors);
            }

            public static void OpenPatients(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(Patients);
            }

            public static void OpenAppointments(FlowLayoutPanel flpCountaner)
            {
                flpCountaner.Controls.Add(Appointments);
            }

        }


        public Form1(frmLogin frm)
        {
            InitializeComponent();

            _Login = frm;

            CurrentButton = btnDashboard;

            SetUcs();
            clsSlidebarOptiones.OpenDashboard(flpCountaner);

           

            LoadInfo();
        }

        void SetUcs()
        {

            clsSlidebarOptiones.Dashboard = new ucDashboard();

            clsSlidebarOptiones.People = new ucPeople();

            clsSlidebarOptiones.People.OnCurrentUserEdit += (s, e) =>
            {
                //int id = clsSettings.CurrentUser.UserID;
                clsSettings.CurrentUser = clsUsers.Find(clsSettings.CurrentUser.UserID);
                LoadInfo();
            };

            clsSlidebarOptiones.Users = new ucUsers();

            clsSlidebarOptiones.Doctors = new ucDoctors();

            clsSlidebarOptiones.Patients = new ucPatients();

            clsSlidebarOptiones.Appointments = new ucAppointments();


            SetRefreshs();
            SetQuickActions();
        }


        void SetRefreshs()
        {
            clsSlidebarOptiones.People.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.Users.RefreshData(this,EventArgs.Empty);
                clsSlidebarOptiones.Doctors.RefreshData(this,EventArgs.Empty);
                clsSlidebarOptiones.Patients.RefreshData(this,EventArgs.Empty);
                clsSlidebarOptiones.Dashboard.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.RefreshData(this,EventArgs.Empty);
            };

            clsSlidebarOptiones.Users.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.People.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Doctors.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Patients.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Dashboard.RefreshData(this, EventArgs.Empty);

            };

            clsSlidebarOptiones.Doctors.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.People.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Users.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Patients.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Dashboard.RefreshData(this, EventArgs.Empty);

            };

            clsSlidebarOptiones.Patients.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.People.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Users.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Doctors.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Dashboard.RefreshData(this, EventArgs.Empty);

            };

            clsSlidebarOptiones.Appointments.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.People.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Users.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Doctors.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Patients.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Dashboard.RefreshData(this, EventArgs.Empty);
            };

            clsSlidebarOptiones.Dashboard.OnRefresh += (ss, ee) =>
            {
                clsSlidebarOptiones.People.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Users.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Doctors.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Patients.RefreshData(this, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.RefreshData(this, EventArgs.Empty);
                clsSettings.CurrentUser = clsUsers.Find(clsSettings.CurrentUser.UserID);
                LoadInfo();
            };


        }

        void SetQuickActions()
        {
            clsSlidebarOptiones.Dashboard.AddPerson += () =>
            {
                ClickSidebarButton(btnPeapol, EventArgs.Empty);
                clsSlidebarOptiones.People.AddPerson();
            };

            clsSlidebarOptiones.Dashboard.AddAppointment += () =>
            {
                ClickSidebarButton(btnAppointments, EventArgs.Empty);
                clsSlidebarOptiones.Appointments.AddAppointment();
            };

            clsSlidebarOptiones.Dashboard.AddDoctor += () =>
            {
                ClickSidebarButton(btnDoctors, EventArgs.Empty);
                clsSlidebarOptiones.Doctors.AddDoctor();
            };

            clsSlidebarOptiones.Dashboard.AddPatient += () =>
            {
                ClickSidebarButton(btnPatients, EventArgs.Empty);
                clsSlidebarOptiones.Patients.AddPatient();
            };

            clsSlidebarOptiones.Dashboard.AddUser += () =>
            {
                ClickSidebarButton(btnUsers, EventArgs.Empty);
                clsSlidebarOptiones.Users.AddUser();
            };


        }


        void LoadInfo()
        {

            if (File.Exists(clsSettings.CurrentUser.Person.ImagePath))
            {
                pbPic.ImageLocation = null;
                pbPic.ImageLocation = clsSettings.CurrentUser.Person.ImagePath;
            }
            else
            {
                if (clsSettings.CurrentUser.Person.IsMale)
                {
                    pbPic.Image = Resources.Boy;
                }
                else
                {
                    pbPic.Image = Resources.Girl;
                }
            }


            if(clsUsers.IsPersonDoctor(clsSettings.CurrentUser.PersonID) )
            {
                lblName.Text = "Dr.";
            }
            lblName.Text += clsSettings.CurrentUser.Person.FirstName + " " + clsSettings.CurrentUser.Person.LastName;

            lblRole.Text = clsSettings.CurrentUser.IsAdmin ? "Admin" : "Doctor";

            if(!clsSettings.CurrentUser.IsAdmin)
            {
                SetforDoctor();
            }

        }

        void SetforDoctor()
        {
            clsSlidebarOptiones.Dashboard.SetForDoctor();

            btnDoctors.Visible = false;
            btnUsers.Visible = false;
        }

        private void ClickSidebarButton(object sender, EventArgs e)
        {
            Guna2GradientButton SenBtn = (Guna2GradientButton)sender;

            if (CurrentButton == SenBtn)
                return;

            if (Enum.TryParse(SenBtn.Tag.ToString(),true, out enSidebar en))
            {
                _eSidebar = en;
            }


            // لاكن هنا بيغير اللون , اللون مش مسوال عن اي حاجه , يعني لو شلت الكود هنا , بردو البرنامج هيشتغل
            ChangeSidebarButtonsColors(CurrentButton,SenBtn);
            CurrentButton = SenBtn;



            //انا هنا بعرض الفورم بس
            Perefourm();
        }

        void ChangeSidebarButtonsColors(Guna2GradientButton oldBtn, Guna2GradientButton newBtn)
        {
            // Activate new button
            newBtn.FillColor = clsSidebarColors.ActiveFill_1;
            newBtn.FillColor2 = clsSidebarColors.ActiveFill_2;
            newBtn.ForeColor = clsSidebarColors.ActiveTextColor;

            // Deactivate old button
            oldBtn.FillColor = clsSidebarColors.DisableFill;
            oldBtn.FillColor2 = clsSidebarColors.DisableFill;
            oldBtn.ForeColor = clsSidebarColors.DisableTextColor;
        }

        void Perefourm()
        {
            flpCountaner.Controls.Clear();

            switch (_eSidebar)
            {
                case enSidebar.Dashboard:
                    clsSlidebarOptiones.OpenDashboard(flpCountaner);
                    break;
                case enSidebar.People:
                    clsSlidebarOptiones.OpenPeople(flpCountaner);
                    break;
                    case enSidebar.Users:
                    clsSlidebarOptiones.OpenUsers(flpCountaner);
                    break;
                case enSidebar.Doctors:
                    clsSlidebarOptiones.OpenDoctors(flpCountaner);
                    break;
                case enSidebar.Patients:
                    clsSlidebarOptiones.OpenPatients(flpCountaner);
                    break;
                case enSidebar.Appointments:
                    clsSlidebarOptiones.OpenAppointments(flpCountaner);
                    break;
                default:
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!Logout)
            Application.Exit();
        }

        private void btnLogOUt_Click(object sender, EventArgs e)
        {
            Logout = true;
            this.Close();
            _Login.Show();
        }
    }
}
