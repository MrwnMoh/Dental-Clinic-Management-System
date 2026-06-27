using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPaymentMethodData
    {

        public static bool FindPaymentMethodByID(int PaymentMethodID, ref string Name)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindPaymentMethodByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PaymentMethodID", PaymentMethodID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            Name = Reader["Name"].ToString();
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
