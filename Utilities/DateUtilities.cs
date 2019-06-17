using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Utilities
{
    public class DateUtilities
    {
        public static DateTime StringToDateTimeES(string date)
        {
            CultureInfo cultureInfo = new CultureInfo("es-ES");
            try
            {
                return DateTime.Parse(date, cultureInfo);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return new DateTime(0, 0, 0);
            }
        }

        public static string DateTimeToStringES(DateTime dateTime)
        {
            string dateString = dateTime.Day.ToString() + "/" +
                                dateTime.Month.ToString() + "/" +
                                dateTime.Year.ToString();

            return dateString;
        }
    }
}
