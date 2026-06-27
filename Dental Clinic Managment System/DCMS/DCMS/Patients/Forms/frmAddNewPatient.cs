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

namespace DCMS.Patients.Forms
{
    public partial class frmAddNewPatient : Form
    {
        bool IsFound = false;

        public event EventHandler Saved;


        clsPatients _Peatient;

        public frmAddNewPatient()
        {
            InitializeComponent();

            ucFilterDetailsWithSerch1.OnFindPerson += (s, e) =>
            {
                IsFound = true;
            };

            ucFilterDetailsWithSerch1.TurnOfEdit();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsFound)
            {
                if(clsUsers.IsPersonPatient(ucFilterDetailsWithSerch1.PeronID))
                {
                    MessageBox.Show(
    "The selected person is already a patient.",
    "Already Registered",
    MessageBoxButtons.OK,
    MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    _Peatient = new clsPatients();
                    _Peatient.PersonID = ucFilterDetailsWithSerch1.PeronID;

                    if(_Peatient.Save())
                    {
                        btnSave.Enabled = false;

                        Saved?.Invoke(this, EventArgs.Empty);

                        MessageBox.Show("Data has been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else
                    {
                        MessageBox.Show("An error occurred while saving.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}
