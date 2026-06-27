using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Business_Layer.clsPayment;

namespace Business_Layer
{
    public class clsPayment
    {

        public int PaymentID { get; set; }
        public int AppointmentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal AmountPaid { get; set; }

        public enum EPaymentMethod {Cash = 1,Card = 2} 
        public EPaymentMethod PaymentMethod { get; set; }

        public clsPayment()
        {
            PaymentID = -1;
            AppointmentID = -1;
            AmountPaid = -1;

            PaymentMethod = EPaymentMethod.Cash;

            PaymentDate = DateTime.MinValue;
        }

        private clsPayment(int paymentID,int paymentMethid,int AppID,DateTime paymentDate,decimal Amount)
        {
            PaymentID = paymentID;
            
            AppointmentID = AppID;
            AmountPaid = Amount;

            PaymentDate = paymentDate;

            PaymentMethod = (EPaymentMethod)paymentMethid;

        }

        private bool _AddNewPayment()
        {
            PaymentID = clsPaymentData.AddPayment(
                (int)PaymentMethod,
                AppointmentID,
                AmountPaid);

            return PaymentID != -1;
        }

        public bool Save()
        {
                if (_AddNewPayment())
                {
                    return true;
                }

            return false;
        }

        public static clsPayment Find(int PaymentID)
        {
            int PaymentMethodID = -1;
            int AppointmentID = -1;
            DateTime PaymentDate = DateTime.MinValue;
            decimal AmountPaid = 0;

            if (clsPaymentData.FindPaymentByID(PaymentID, ref PaymentMethodID, ref AppointmentID, ref PaymentDate, ref AmountPaid))
            {
                return new clsPayment(PaymentID, PaymentMethodID, AppointmentID, PaymentDate, AmountPaid);
            }

            return null;
        }

        public static clsPayment FindByAppointmentID(int AppointmentID)
        {
            int PaymentMethodID = -1;
            int PaymentID = -1;
            DateTime PaymentDate = DateTime.MinValue;
            decimal AmountPaid = 0;

            if (clsPaymentData.FindPaymentByAppointmentID(ref PaymentID, ref PaymentMethodID,  AppointmentID, ref PaymentDate, ref AmountPaid))
            {
                return new clsPayment(PaymentID, PaymentMethodID, AppointmentID, PaymentDate, AmountPaid);
            }

            return null;
        }


    }
}
