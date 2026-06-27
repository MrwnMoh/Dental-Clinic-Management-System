using DCMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCMS.Treatmets
{
    public partial class ucTreatentRow : UserControl
    {
         int _ID;
         string _TreatmentName;
         decimal _Price;

        RowArgs _RowArgs;

        public class RowArgs : EventArgs
        {
            public int ID { get; }
            public  string Name { get; }
            public decimal Price { get; }

            public RowArgs(int iD, string name, decimal price)
            {
                ID = iD;
                Name = name;
                Price = price;
            }
        
        }

        public event EventHandler<RowArgs> OnTreatmentSelected;

        public event EventHandler<RowArgs> OnTreatmentDeSelected;


        public ucTreatentRow(int ID,string name,string ImagePath,decimal price)
        {
            InitializeComponent();

            lblName.Text = name;
            lblPrice.Text = price.ToString("N2");
            lblID.Text = ID.ToString();

            if(File.Exists(ImagePath))
            {
                pbPic.ImageLocation = ImagePath;
            }
          
            _ID = ID;
            _TreatmentName = name;
            _Price = price;

            _RowArgs = new RowArgs(_ID, _TreatmentName, _Price);

                RegisterHoverEvents(this);
        }

        private void RegisterHoverEvents(Control parent)
        {
            parent.MouseEnter += Control_MouseEnter;
            parent.MouseLeave += Control_MouseLeave;
            parent.Click += Control_MouseClick;

            foreach (Control c in parent.Controls)
            {
                RegisterHoverEvents(c);
            }
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            SetPanelColorToOnEnter();
        }

        private void Control_MouseClick(object sender, EventArgs e)
        {
            SetPanelColorToSelected();
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            Point mousePos = this.PointToClient(Cursor.Position);

            if (!this.ClientRectangle.Contains(mousePos))
            {
                SetPanelColorToDefult();
            }
        }

        public void DeactivedSelect()
        {
            chkSelected.Enabled = false;
        }

        void SetPanelColorToOnEnter()
        {
            pnlGroupALL.FillColor = Color.FromArgb(235, 243, 254);
        }

        void SetPanelColorToDefult()
        {
            pnlGroupALL.FillColor = Color.Transparent;
        }

        void SetPanelColorToSelected()
        {
            pnlGroupALL.FillColor = Color.FromArgb(210, 228, 254);
        }

        private void chkSelected_Click(object sender, EventArgs e)
        {
            if(chkSelected.Checked)
            {
                OnTreatmentSelected?.Invoke(this, _RowArgs);
            }
            else
            {
                OnTreatmentDeSelected?.Invoke(this, _RowArgs);
            }

        }
    }
}
