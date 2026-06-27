using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsStatisticsData
    {
        public static int GetDoctorsCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("sp_GetDoctorsCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter Param =
                            new SqlParameter("@Count", SqlDbType.Int);

                        Param.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(Param);

                        cmd.ExecuteNonQuery();

                        Count = Convert.ToInt32(cmd.Parameters["@Count"].Value);
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetUsersCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("sp_GetUsersCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter Param =
                            new SqlParameter("@Count", SqlDbType.Int);

                        Param.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(Param);

                        cmd.ExecuteNonQuery();

                        Count = Convert.ToInt32(cmd.Parameters["@Count"].Value);
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetAdminsCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("sp_GetAdminsCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter Param =
                            new SqlParameter("@Count", SqlDbType.Int);

                        Param.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(Param);

                        cmd.ExecuteNonQuery();

                        Count = Convert.ToInt32(cmd.Parameters["@Count"].Value);
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetActiveUsersCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("sp_GetActiveUsersCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter Param =
                            new SqlParameter("@Count", SqlDbType.Int);

                        Param.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(Param);

                        cmd.ExecuteNonQuery();

                        Count = Convert.ToInt32(cmd.Parameters["@Count"].Value);
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetPatientsCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                        new SqlCommand("sp_GetPatientsCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter Param =
                            new SqlParameter("@Count", SqlDbType.Int);

                        Param.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(Param);

                        cmd.ExecuteNonQuery();

                        Count = Convert.ToInt32(cmd.Parameters["@Count"].Value);
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetTotalConfirmdAppointments()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection =new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTotalConfirmdAppointments", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int sp_GetTotalCancelledAppointments()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTotalCancelledAppointments", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int sp_GetTotalPendingAppointments()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTotalPendingAppointments", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int sp_GetTotalAppointments()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTotalAppointments", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static int GetTreatmentsCount()
        {
            int Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTreatmentsCount", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }

        public static decimal GetTotalRevenue()
        {
            decimal Count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_GetTotalRevenue", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        Count = Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch
            {
            }

            return Count;
        }


    }
}
