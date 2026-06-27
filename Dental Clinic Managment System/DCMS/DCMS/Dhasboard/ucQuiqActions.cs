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
    public partial class ucQuiqActions : UserControl
    {

        public event Action AddPerson;

        public event Action AddDoctor;

        public event Action AddAppointment;

        public event Action AddUser;

        public event Action AddPatient;


        public void SetForDoctor()
        {
            btnAddDoctor.Enabled = false;
            btnAddUser.Enabled = false;
        }


        public ucQuiqActions()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson?.Invoke();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatient?.Invoke();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser?.Invoke();

        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor?.Invoke();

        }

        private void btnAddappointment_Click(object sender, EventArgs e)
        {
            AddAppointment?.Invoke();

        }
    }
}
