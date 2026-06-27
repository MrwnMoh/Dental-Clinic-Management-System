using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPatientsData
    {


        public static bool DeletePatient(int PatientID)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeletePatient", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@PatientID", PatientID);

                        Connection.Open();

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return RowsAffected > 0;
        }

        public static bool FindPatientByID(int PatientID, ref int PersonID, ref DateTime CreatedAt)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindPatientByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@PatientID", PatientID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            PersonID = (int)Reader["PersonID"];
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

        public static bool FindPatientByPersonID(int PersonID, ref int PatientID, ref DateTime CreatedAt)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindPatientByPersonID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;
                            PatientID = (int)Reader["PatientID"];
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

        public static int AddPatient(int PersonID)
        {
            int PatientID = -1;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_AddPatient", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@PersonID", PersonID);

                    SqlParameter OutputID = new SqlParameter("@PatientID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;


                    Command.Parameters.Add(OutputID);

                    Connection.Open();
                    Command.ExecuteNonQuery();

                    if (OutputID.Value != DBNull.Value)
                        PatientID = (int)OutputID.Value;
                }
            }
            catch (Exception ex)
            {
            }

            return PatientID;
        }

        static public DataTable GetSummaryPatientData()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "sp_GetSummaryPatientData";

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




    }
}
