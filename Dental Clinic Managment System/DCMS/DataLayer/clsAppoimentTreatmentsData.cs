using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsAppoimentTreatmentsData
    {

        public static int AddAppointmentTreatment(int AppointmentID, int TreatmentID, decimal UnitPrice)
        {
            int AppointmentTreatmentID = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_AddAppointmentTreatment", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@TreatmentID", TreatmentID);
                    Command.Parameters.AddWithValue("@UnitPrice", UnitPrice);

                    SqlParameter Param = new SqlParameter("@AppointmentTreatmentID", SqlDbType.Int);
                    Param.Direction = ParameterDirection.Output;

                    Command.Parameters.Add(Param);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    if (Param.Value != DBNull.Value)
                        AppointmentTreatmentID = Convert.ToInt32(Param.Value);
                }
            }
            catch (Exception ex)
            {
            }

            return AppointmentTreatmentID;
        }



    }
}
