using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDoctorsData
    {
        public static int AddDoctor(int UserID, int SpecializationID, decimal Salary, DateTime HiringDate, DateTime? LeaveDate)
        {
            int DoctorID = -1;

            using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("sp_AddDoctor", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
                    Command.Parameters.AddWithValue("@Salary", Salary);
                    Command.Parameters.AddWithValue("@HiringDate", HiringDate);

                    if (LeaveDate.HasValue)
                        Command.Parameters.AddWithValue("@LeaveDate", LeaveDate.Value);
                    else
                        Command.Parameters.AddWithValue("@LeaveDate", DBNull.Value);

                    SqlParameter OutputID = new SqlParameter("@DoctorID", SqlDbType.Int);
                    OutputID.Direction = ParameterDirection.Output;

                    Command.Parameters.Add(OutputID);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    if (OutputID.Value != DBNull.Value)
                    {
                        DoctorID = (int)OutputID.Value;
                    }
                }
            }

            return DoctorID;
        }

        public static bool UpdateDoctor(int DoctorID,int SpecializationID, decimal Salary, DateTime HiringDate, DateTime? LeaveDate)
        {
            int RowsAffected = 0;

            using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("sp_UpdateDoctor", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@DoctorID", DoctorID);
                    Command.Parameters.AddWithValue("@SpecializationID", SpecializationID);
                    Command.Parameters.AddWithValue("@Salary", Salary);
                    Command.Parameters.AddWithValue("@HiringDate", HiringDate);

                    if (LeaveDate.HasValue)
                        Command.Parameters.AddWithValue("@LeaveDate", LeaveDate);
                    else
                        Command.Parameters.AddWithValue("@LeaveDate", DBNull.Value);


                    Connection.Open();

                    RowsAffected = Command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }

        public static bool FindDoctorByID(int DoctorID,ref int UserID,ref int SpecializationID,ref decimal Salary,ref DateTime HiringDate,ref DateTime? LeaveDate)
        {
            bool IsFound = false;

            using (SqlConnection Connection =new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command =new SqlCommand("sp_FindDoctorByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@DoctorID", DoctorID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            UserID = (int)Reader["UserID"];
                            SpecializationID = (int)Reader["SpecializationID"];
                            Salary = (decimal)Reader["Salary"];
                            HiringDate = (DateTime)Reader["HiringDate"];

                            if (Reader["LeaveDate"] != DBNull.Value)
                                LeaveDate = (DateTime?)Reader["LeaveDate"];
                            else
                                LeaveDate = null;
                        }
                    }
                }
            }

            return IsFound;
        }

        public static bool FindDoctorByUserID(int UserID,ref int DoctorID,ref int SpecializationID,ref decimal Salary,ref DateTime HiringDate,ref DateTime? LeaveDate)
        {
            bool IsFound = false;

            using (SqlConnection Connection =new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command =new SqlCommand("sp_FindDoctorByUserID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@UserID", UserID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            DoctorID = (int)Reader["DoctorID"];
                            SpecializationID = (int)Reader["SpecializationID"];
                            Salary = (decimal)Reader["Salary"];
                            HiringDate = (DateTime)Reader["HiringDate"];

                            if (Reader["LeaveDate"] != DBNull.Value)
                                LeaveDate = (DateTime?)Reader["LeaveDate"];
                            else
                                LeaveDate = null;
                        }
                    }
                }
            }

            return IsFound;
        }

        static public DataTable GetDoctorsDataWithDetails()
        {

            DataTable dt = new DataTable();

            try
            {
                string qurey = "sp_GetDoctorsDataWithDetails";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
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
                //code
            }


            return dt;
        }

        public static bool DeleteDoctor(int DoctorID)
        {
            int RowsAffected = 0;

            using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command = new SqlCommand("sp_DeleteDoctor", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@DoctorID", DoctorID);

                    Connection.Open();

                    RowsAffected = Command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }


    }

}
