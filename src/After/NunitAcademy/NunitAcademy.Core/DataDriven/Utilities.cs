using System;
using System.Collections.Generic;
using System.Text;

namespace NunitAcademy.Core.DataDriven
{
    public static class Utilities
    {
        public enum WeekDays
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        public static string getFullName(string firstName, string lastname)
        {
            return String.Concat(firstName, lastname);
        }

        public static int getDayOfWeek(WeekDays weekDay)
        {
            return (int)weekDay + 1;
        }
    }
}
