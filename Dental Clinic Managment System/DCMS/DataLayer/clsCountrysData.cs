using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsCountrysData
    {

        static public DataTable LoadAllCountrysNames()
        {

            DataTable dt = new DataTable();

            try
            {
                string qurey = "sp_GetAllCountrysNames";

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

        static public bool GetCountryByID(int ID, ref string name)
        {
            bool IsFound = false;
            try
            {
                string qurey = "sp_GetCountryByID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", ID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;

                                name = Reader["Name"].ToString();

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


    }
}
