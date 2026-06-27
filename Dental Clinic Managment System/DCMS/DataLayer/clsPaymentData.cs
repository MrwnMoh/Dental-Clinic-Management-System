using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPaymentData
    {

        public static int AddPayment(int PaymentMethodID, int AppointmentID, decimal AmountPaid)
        {
            int PaymentID = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_AddPayment", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);
                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@AmountPaid", AmountPaid);

                    SqlParameter Param = new SqlParameter("@PaymentID", SqlDbType.Int);
                    Param.Direction = ParameterDirection.Output;

                    Command.Parameters.Add(Param);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    if (Param.Value != DBNull.Value)
                        PaymentID = Convert.ToInt32(Param.Value);
                }
            }
            catch (Exception ex)
            {
            }

            return PaymentID;
        }

        public static bool FindPaymentByID(int PaymentID, ref int PaymentMethodID, ref int AppointmentID, ref DateTime PaymentDate, ref decimal AmountPaid)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindPaymentByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PaymentID", PaymentID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            PaymentMethodID = (int)Reader["PaymentMethodID"];
                            AppointmentID = (int)Reader["AppointmentID"];
                            PaymentDate = (DateTime)Reader["PaymentDate"];
                            AmountPaid = (decimal)Reader["AmountPaid"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return IsFound;
        }

        public static bool FindPaymentByAppointmentID(ref int PaymentID, ref int PaymentMethodID,  int AppointmentID, ref DateTime PaymentDate, ref decimal AmountPaid)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindPaymentByAppointmentID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@AppID", AppointmentID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            PaymentMethodID = (int)Reader["PaymentMethodID"];
                            PaymentID = (int)Reader["PaymentID"];
                            PaymentDate = (DateTime)Reader["PaymentDate"];
                            AmountPaid = (decimal)Reader["AmountPaid"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return IsFound;
        }


    }
}
