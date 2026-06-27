using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class clsStatistics
    {
        public static int GetDoctorsCount()
        {
            return clsStatisticsData.GetDoctorsCount();
        }

        public static int GetUsersCount()
        {
            return clsStatisticsData.GetUsersCount();
        }

        public static int GetAdminsCount()
        {
            return clsStatisticsData.GetAdminsCount();
        }

        public static int GetActiveUsersCount()
        {
            return clsStatisticsData.GetActiveUsersCount();
        }

        public static int GetPatientsCount()
        {
            return clsStatisticsData.GetPatientsCount();
        }

        public static int GetTotalConfirmdAppointments()
        {
            return clsStatisticsData.GetTotalConfirmdAppointments();
        }

        public static int GetTotalCancelledAppointments()
        {
            return clsStatisticsData.sp_GetTotalCancelledAppointments();
        }

        public static int GetTotalPendingAppointments()
        {
            return clsStatisticsData.sp_GetTotalPendingAppointments();
        }

        public static int GetTotalAppointments()
        {
            return clsStatisticsData.sp_GetTotalAppointments();
        }

        public static int GetTreatmentsCount()
        {
            return clsStatisticsData.GetTreatmentsCount();
        }

        public static decimal GetTotalRevenue()
        {
            return clsStatisticsData.GetTotalRevenue();
        }

    }
}
