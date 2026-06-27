using Business_Layer;
using DCMS.Dhasboard.Totals;
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

namespace DCMS.Dhasboard
{
    public partial class ucDashboard : UserControl
    {
        public event EventHandler OnRefresh;

        public event Action AddPerson;

        public event Action AddDoctor;

        public event Action AddAppointment;

        public event Action AddUser;

        public event Action AddPatient;

        DataTable dt;
        DataView dv;

        public ucDashboard()
        {
            InitializeComponent();

            ucPersonInfoCard1.SetPersonDataByPersonID(clsSettings.CurrentUser.PersonID);

           

            ucPersonInfoCard1.OnCurrentUserEdit += (s, e) =>
            { 
                OnRefresh?.Invoke(s, e);
                RefreshData(s, e);
            };

            dt = clsTreatments.GetAllTreatments();
            dv = dt.DefaultView;
            LoadTreatments();


            SubToQuick();

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

                uc.DeactivedSelect();

                fpnlContater.Controls.Add(uc);
            }

        }


        public void SetForDoctor()
        {
            ucQuiqActions1.SetForDoctor();
        }

        void SubToQuick()
        {
            ucQuiqActions1.AddAppointment += () => AddAppointment?.Invoke();

            ucQuiqActions1.AddPerson += () => AddPerson?.Invoke();

            ucQuiqActions1.AddDoctor += () => AddDoctor?.Invoke();

            ucQuiqActions1.AddUser += () => AddUser?.Invoke();

            ucQuiqActions1.AddPatient += () => AddPatient?.Invoke();
        }

        public void RefreshData(object sender, EventArgs e)
        {
            

            ucPersonInfoCard1.SetPersonDataByPersonID(clsSettings.CurrentUser.PersonID);

            ucMainSmalTotalCard4.RefreshCounter();
            ucMainSmalTotalCard1.RefreshCounter();
            ucMainSmalTotalCard2.RefreshCounter();
            ucMainSmalTotalCard3.RefreshCounter();
        }


    }
}
