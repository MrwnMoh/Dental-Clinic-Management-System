using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer
{
    public class clsUsersData
    {

        public static bool IsAdmin(int personID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand cmd = new SqlCommand("sp_IsAdmin", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PersonID", personID);

                    connection.Open();

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                        return Convert.ToBoolean(result);

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsPatient(int PersonID)
        {
            bool IsTrue = false;

            try
            {
                string qurey = "sp_IsPatient";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsTrue = true;
                            }
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                IsTrue = false;
            }






            return IsTrue;
        }

        public static bool IsPersonDoctor(int PersonID)
        {
            bool IsTrue = false;

            try
            {
                string qurey = "sp_IsPersonDoctor";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsTrue = true;
                            }
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                IsTrue = false;
            }






            return IsTrue;
        }

        public static bool IsUserDoctor(int UserID)
        {
            bool IsTrue = false;

            try
            {
                string qurey = "sp_IsUserDoctor";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsTrue = true;
                            }
                        }

                    }

                }


            }
            catch (Exception ex)
            {
                IsTrue = false;
            }






            return IsTrue;
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "sp_GetAllUsers";

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

        static public DataTable GetAllUsersInfoWithPeople()
        {
            DataTable dt = new DataTable();

            try
            {
                string query = "sp_GetAllUsersInfoWithPeople";

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



        static public bool FindUserByID(int UserID,ref int PersonID,ref int CreatedBy,ref string Username,ref string Password,ref DateTime CreatedAt,ref bool IsActive,ref bool IsAdmin)
        {
            bool IsFound = false;

            try
            {
                string query = "sp_FindUserByUserID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = Convert.ToInt32(reader["PersonID"]);
                                CreatedBy = reader["CreatedBy"] == DBNull.Value ? -1 : Convert.ToInt32(reader["CreatedBy"]);

                                Username = reader["Username"].ToString();
                                Password = reader["PasswordHash"].ToString();

                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);


                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

        static public bool FindUserByPersonID(int PersonID,ref int UserID,ref int CreatedBy,ref string Username,ref string Password,ref DateTime CreatedAt,ref bool IsActive,ref bool IsAdmin)
        {
            bool IsFound = false;

            try
            {
                string query = "sp_FindUserByPersonID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = Convert.ToInt32(reader["UserID"]);
                                CreatedBy = reader["CreatedBy"] == DBNull.Value ? -1 : Convert.ToInt32(reader["CreatedBy"]);

                                Username = reader["Username"].ToString();
                                Password = reader["PasswordHash"].ToString();

                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);


                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

        static public int AddNewUser(int PersonID, int CreatedBy, string Username, string Password,bool IsActive, bool IsAdmin)
        {
            int ID = -1;

            try
            {
                string query = "sp_CreateNewUser";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@PasswordHash", Password);
                        cmd.Parameters.AddWithValue("@IsActive", IsActive);
                        cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);

                        SqlParameter userIDParam = new SqlParameter("@UserID", SqlDbType.Int);
                        userIDParam.Direction = ParameterDirection.Output;

                        cmd.Parameters.Add(userIDParam);

                        cmd.ExecuteNonQuery();

                        ID = (int)userIDParam.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }

            return ID;
        }

        static public bool FindUserByUsernameAndPassword(string Username,string Password,ref int UserID,ref int PersonID,ref int CreatedBy,ref DateTime CreatedAt,ref bool IsActive,ref bool IsAdmin)
        {
            bool IsFound = false;

            try
            {
                string query = "sp_FindUserByUsernameAndPassword";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Username", Username);
                        cmd.Parameters.AddWithValue("@Password", Password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                UserID = Convert.ToInt32(reader["UserID"]);
                                PersonID = Convert.ToInt32(reader["PersonID"]);

                                CreatedBy = reader["CreatedBy"] == DBNull.Value ? -1 : Convert.ToInt32(reader["CreatedBy"]);

                                CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);

                            

                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                IsFound = false;
            }

            return IsFound;
        }

        public static bool UpdateUser(int UserID,string Username,string Password,bool IsActive,bool IsAdmin)
        {
            int RowsAffected = 0;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_UpdateUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserID", UserID);
                        Command.Parameters.AddWithValue("@Username", Username);
                        Command.Parameters.AddWithValue("@PasswordHash", Password);
                        Command.Parameters.AddWithValue("@IsActive", IsActive);
                        Command.Parameters.AddWithValue("@IsAdmin", IsAdmin);

                        Connection.Open();

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }
            }
            catch { }

            return RowsAffected > 0;
        }


        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            
            try
            {using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                {
                    using (SqlCommand Command = new SqlCommand("sp_DeleteUser", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;

                        Command.Parameters.AddWithValue("@UserID", UserID);

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


        public static string GetUsernameByUserID(int UserID)
        {
            string Username = "";

            using (SqlConnection Connection =
                new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command =
                    new SqlCommand("sp_GetUsernameByUserID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        Connection.Open();

                        object Result = Command.ExecuteScalar();

                        if (Result != null && Result != DBNull.Value)
                            Username = Result.ToString();
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            return Username;
        }


    }
}
