using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsPaymentMethod
    {

        public int PaymentMethodID { get; set; }
        public string Name { get; set; }

        public clsPaymentMethod()
        {
            PaymentMethodID = -1;
            Name = string.Empty;
        }

        private clsPaymentMethod(int id, string name)
        {
            PaymentMethodID = id;
            Name = name;
        }

        public static clsPaymentMethod Find(int PaymentMethodID)
        {
            string Name = string.Empty;

            if (clsPaymentMethodData.FindPaymentMethodByID(PaymentMethodID, ref Name))
            {
                return new clsPaymentMethod(PaymentMethodID, Name);
            }

            return null;
        }


    }
}
