using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsBloodTypeData
    {
        static public DataTable GetAllBloodTypes()
        {

            DataTable dt = new DataTable();

            try
            {
                string qurey = "sp_GetAllBloodTypes";

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

        static public bool GetBloodbyID(int ID,ref string name)
        {
            bool IsFound = false;
            try
            {
                string qurey = "sp_GetBloodbyID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@BloodID", ID);

                        using (SqlDataReader Reader = cmd.ExecuteReader())
                        {
                            if (Reader.Read())
                            {
                                IsFound = true;

                                name = Reader["BloodTypeName"].ToString();
                                
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
