using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsTreatmentsData
    {

        public static bool FindTreatmentByID(int TreatmentID, ref string Name, ref string Notes,ref string imagePath, ref decimal Price)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_FindTreatmentByID", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Command.Parameters.AddWithValue("@TreatmentID", TreatmentID);

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.Read())
                        {
                            IsFound = true;

                            Name = Reader["Name"].ToString();

                            imagePath = Reader["ImagePath"].ToString();

                            if (Reader["Notes"] == DBNull.Value)
                                Notes = null;
                            else
                                Notes = Reader["Notes"].ToString();

                            Price = (decimal)Reader["Price"];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return IsFound;
        }

        public static DataTable GetAllTreatments()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection Connection = new SqlConnection(clsDefSettings.ConnectionString))
                using (SqlCommand Command = new SqlCommand("sp_GetAllTreatments", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                    Connection.Open();

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                            dt.Load(Reader);
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return dt;
        }

    }
}
