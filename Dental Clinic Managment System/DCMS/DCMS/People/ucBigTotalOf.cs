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
using static DCMS.Dhasboard.Totals.ucMainSmalTotalCard;

namespace DCMS.People
{
    public partial class ucBigTotalOf : UserControl
    {

        public enum ETypes
        {
            People,
            Patients
        }
        private ETypes _cardType = ETypes.People;

        public ETypes CardType
        {
            get => _cardType;
            set
            {
                _cardType = value;
                _UpdateCardDesign();
            }
        }

        public ucBigTotalOf()
        {
            InitializeComponent();
        }

        void _UpdateCardDesign()
        {
            switch (_cardType)
            {
                case ETypes.People:
                    _SetForPeople();
                    break;
                    case ETypes.Patients:
                    _SetForPataients();
                    break;
                default:
                    break;
            }
        }

        void _SetForPeople()
        {
            lblTotalOF.Text = "People";
            pbPic.Image = Resources.Patients;
            lblSumary.Text = "All registers People";
        }

        void _SetForPataients()
        {
            lblTotalOF.Text = "Patients";
            pbPic.Image = Resources.patient;
            lblSumary.Text = "All Patient Records";
        }


        public void SetCount(int count)
        {
            lblCount.Text = count.ToString();
        }

    }
}
