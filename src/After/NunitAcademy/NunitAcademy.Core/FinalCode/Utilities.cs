using System;
using System.Collections.Generic;
using System.Management;
using System.Text;

namespace NunitAcademy.Core.FinalCode
{
    public static class Utilities
    {
        public static string getDmtfFromDateTime(DateTime dateTime)
        {
            return ManagementDateTimeConverter.ToDmtfDateTime(dateTime);
        }

        public static string getDmtfFromDateTime(string dateTime)
        {
            DateTime dateTimeValue = Convert.ToDateTime(dateTime);
            return getDmtfFromDateTime(dateTimeValue);
        }

        public static string getStringDateTimeFromDmtfDate(string dateTime)
        {
            return ManagementDateTimeConverter.ToDateTime(dateTime).ToString();
        }

        public static DateTime getDateTimeFromDmtfDate(string dateTime)
        {
            return ManagementDateTimeConverter.ToDateTime(dateTime);
        }
    }
}
