using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsAppointmentsData
    {

        public static bool UpdateAppointment(int AppointmentID, DateTime AppointmentDate, string Notes, byte Status,decimal Price)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_UpdateAppointment", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);
                    Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                    if (Notes == null)
                        Command.Parameters.AddWithValue("@Notes", DBNull.Value);
                    else
                        Command.Parameters.AddWithValue("@Notes", Notes);
                    Command.Parameters.AddWithValue("@Status", Status);
                    Command.Parameters.AddWithValue("@Price", Price);

                    Connection.Open();

                    RowsAffected = Command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }

            return RowsAffected > 0;
        }

        public static int AddAppointment(int PatientID, int DoctorID, string Notes, decimal Price, DateTime AppointmentDate)
        {
            int AppointmentID = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_AddAppointment", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PatientID", PatientID);
                    Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    Command.Parameters.AddWithValue("@Notes", Notes);
                    Command.Parameters.AddWithValue("@Price", Price);
                    Command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

                    SqlParameter Param = new SqlParameter("@AppointmentID", SqlDbType.Int);
                    Param.Direction = ParameterDirection.Output;

                    Command.Parameters.Add(Param);

                    Connection.Open();
                    Command.ExecuteNonQuery();

                    if (Param.Value != DBNull.Value)
                        AppointmentID = Convert.ToInt32(Param.Value);
                }
            }
            catch (Exception ex)
            {
            }

            return AppointmentID;
        }

        static public DataTable GetAppointmentsSummary()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "sp_GetAppointmentsSummary";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            dt.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // code
            }

            return dt;
        }

        public static bool FindAppointmentByID(int AppointmentID, ref int PatientID, ref int DoctorID, ref byte Status, ref string Notes, ref decimal Price, ref DateTime AppointmentDate, ref DateTime CreatedAt)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindAppointmentByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            PatientID = (int)Reader["PatientID"];
                            DoctorID = (int)Reader["DoctorID"];
                            Status = Convert.ToByte(Reader["Status"]);

                            if(Reader["Notes"] == DBNull.Value)
                            {
                                Notes = null;
                            }
                            else
                            {
                                Notes =Reader["Notes"].ToString();
                            }

                            Price = (decimal)Reader["Price"];
                            AppointmentDate = (DateTime)Reader["AppointmentDate"];
                            CreatedAt = (DateTime)Reader["CreatedAt"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return IsFound;
        }

        public static bool DeleteAppointment(int AppointmentID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteAppointment", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                        Connection.Open();

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {

            }

            return RowsAffected > 0;
        }

        public static bool CancelAppointment(int AppointmentID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_CancelAppointment", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    Connection.Open();

                    RowsAffected = Command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
            }

            return RowsAffected > 0;
        }

        public static DataTable GetAppointmentTreatments(int appointmentID)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetAppointmentTreatments", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppID", appointmentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }
            }
            catch
            {
                // Handle Exception
            }

            return dt;
        }

        public static decimal GetTotalAppointmentPaid(int appointmentID)
        {
            decimal amountPaid = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("sp_GetTotalAppoitmentPaid", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AppID", appointmentID);

                        SqlParameter output = new SqlParameter("@Res", SqlDbType.Decimal);
                        output.Precision = 18;
                        output.Scale = 2;
                        output.Direction = ParameterDirection.Output;

                        command.Parameters.Add(output);

                        command.ExecuteNonQuery();

                        if (output.Value != DBNull.Value)
                            amountPaid = Convert.ToDecimal(output.Value);
                    }
                }
            }
            catch
            {
                // Handle Exception
            }

            return amountPaid;
        }



    }
}
