using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsSpecializationData
    {

        public static DataTable GetAllSpecializations()
        {
            DataTable dt = new DataTable();

            using (SqlConnection Connection =
                new SqlConnection(clsDefSettings.ConnectionString))
            {
                using (SqlCommand Command =
                    new SqlCommand("sp_GetAllSpecializations", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Connection.Open();

                    dt.Load(Command.ExecuteReader());
                }
            }

            return dt;
        }

        static public bool GetSpecializationByID(int SpecializationByID, ref string name)
        {
            bool IsFound = false;
            try
            {
                string qurey = "sp_FindSpecializationByID";

                using (SqlConnection connection = new SqlConnection(clsDefSettings.ConnectionString))
                {

                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(qurey, connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@SpecializationByID", SpecializationByID);

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
