using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsPeopleData
    {

        static public DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();

            try
            {
                string qurey = "sp_GetAllPeople";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {

                        using(SqlDataReader reader = cmd.ExecuteReader())
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

        static public bool FindPersonByID(int ID,ref int BloodTypeID,ref int CountryID, ref string FirstName, ref string LastName, ref string Address, ref string Email, ref string Phone, ref string ImagePath,ref DateTime BirtdDate,ref bool IsMale)
        {
             bool IsFound = false;
            try
            {
                string qurey = "sp_FindPersonByID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID",ID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if(Reader.Read())
                            {
                                IsFound = true;

                                BloodTypeID = Convert.ToInt32(Reader["BloodTypeID"]);
                                CountryID = Convert.ToInt32(Reader["CountryID"]);

                                FirstName = Reader["FirstName"].ToString();
                                LastName = Reader["LastName"].ToString();
                                Address = Reader["Address"].ToString();
                                Email = Reader["Email"] == DBNull.Value ? "" : Reader["Email"].ToString();
                                Phone = Reader["Phone"].ToString();

                                ImagePath = Reader["ImagePath"] == DBNull.Value
                                    ? ""
                                    : Reader["ImagePath"].ToString();

                                BirtdDate = Convert.ToDateTime(Reader["BirthDate"]);
                                IsMale = Convert.ToBoolean(Reader["IsMale"]);

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

        static public int AddNewPerson(int BloodTypeID,  int CountryID,  string FirstName,  string LastName,  string Address,  string Email,  string Phone,  string ImagePath,  DateTime BirtdDate,  bool IsMale)
        {
            int ID = -1;

            try
            {
                string qurey = "sp_CreateNewPerson";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BloodTypeID", BloodTypeID);
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Address", Address);

                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(Email) ? DBNull.Value : (object)Email;
                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(ImagePath) ? DBNull.Value : (object)ImagePath;

                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@BirthDate", BirtdDate);
                        cmd.Parameters.AddWithValue("@IsMale", IsMale);

                        SqlParameter personIDParam =new SqlParameter("@PersonID", SqlDbType.Int);
                        personIDParam.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(personIDParam);

                        cmd.ExecuteNonQuery();

                        ID = (int)personIDParam.Value;

                    }

                }


            }
            catch (Exception ex)
            {
                return -1;
            }


            return ID;
        }

        static public bool UpdatePerson(int PersonID,int BloodTypeID,int CountryID,string FirstName,string LastName,string Address,string Email,string Phone,string ImagePath,DateTime BirthDate,bool IsMale)
        {
            int rows = 0;

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                           new SqlCommand("sp_UpdatePerson", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        cmd.Parameters.AddWithValue("@BloodTypeID", BloodTypeID);
                        cmd.Parameters.AddWithValue("@CountryID", CountryID);
                        cmd.Parameters.AddWithValue("@FirstName", FirstName);
                        cmd.Parameters.AddWithValue("@LastName", LastName);
                        cmd.Parameters.AddWithValue("@Address", Address);


                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(Email) ? DBNull.Value : (object)Email;



                        cmd.Parameters.Add("@ImagePath", SqlDbType.NVarChar).Value = string.IsNullOrEmpty(ImagePath) ? DBNull.Value : (object)ImagePath;


                        cmd.Parameters.AddWithValue("@Phone", Phone);
                        cmd.Parameters.AddWithValue("@BirthDate", BirthDate);
                        cmd.Parameters.AddWithValue("@IsMale", IsMale);

                        rows = cmd.ExecuteNonQuery();

                        
                    }
                }
            }
            catch
            {
                rows = 0;
            }


            return rows > 0;
        }

        static public bool DeletePerson(int PersonID)
        {
            int rows = 0;

            try
            {
                using (SqlConnection connection =
                       new SqlConnection(clsDefSettings.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd =
                           new SqlCommand("sp_DeletePerson", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PersonID", PersonID);
                        rows = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                rows = 0;
            }


            return rows > 0;
        }


    }

}
