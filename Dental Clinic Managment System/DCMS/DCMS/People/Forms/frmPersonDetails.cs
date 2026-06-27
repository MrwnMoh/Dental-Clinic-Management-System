using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.People.Forms
{
    public partial class frmPersonDetails : Form
    {
        public event EventHandler OnEdit;
        public event EventHandler OnCurrentUserEdit;


        public frmPersonDetails()
        {
            InitializeComponent();
            ucFilterDetailsWithSerch1.OnEdit += OnEdit;
        }

        public frmPersonDetails(int PersinID)
        {
            InitializeComponent();


            ucFilterDetailsWithSerch1.OnEdit += OnEdit;
            ucFilterDetailsWithSerch1.OnCurrentUserEdit += OnCurrentUserEdit;

            clsPeople Person = clsPeople.Find(PersinID);
            ucFilterDetailsWithSerch1.SetData(Person);

            ucFilterDetailsWithSerch1.TurnOfSearch();
        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
