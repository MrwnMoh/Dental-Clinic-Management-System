using DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsTreatments
    {

        public int TreatmentID { get; set; }
        public string TreatmentName { get; set; }
        public string Notes { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }

        public clsTreatments()
        {
            TreatmentID = -1;
            Price = -1;
            TreatmentName = string.Empty;
            ImagePath = string.Empty;
            Notes = string.Empty;
        }

        private clsTreatments(int treatmentID, string treatmentName, string notes,string imagePath, decimal price)
        {
            TreatmentID = treatmentID;
            TreatmentName = treatmentName;
            Notes = notes;
            Price = price;
            ImagePath = imagePath;
        }

        public static clsTreatments Find(int TreatmentID)
        {
            string Name = string.Empty;
            string imagePath = string.Empty;
            string Notes = null;
            decimal Price = 0;

            if (clsTreatmentsData.FindTreatmentByID(TreatmentID, ref Name, ref Notes,ref imagePath, ref Price))
            {
                return new clsTreatments(TreatmentID, Name, Notes,imagePath, Price);
            }

            return null;
        }

        public static DataTable GetAllTreatments()
        {
            return clsTreatmentsData.GetAllTreatments();
        }


    }
}
