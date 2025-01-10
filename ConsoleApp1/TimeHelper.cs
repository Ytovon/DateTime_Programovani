
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class TimeHelper
    {
        static string format = "dd/MM/yyyy";

        public static string GetDayOfWeek()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            DateTime dateTime = DateTime.Now;

            return dateTime.ToString("dddd", currentCulture);
        }

        public static string CalculateDifferenceNow()
        {
            DateTime dateTime = GetUserDate("Napište datum ve formátu dd/MM/yyyy (např. 10/12/2024)");
            DateTime now = DateTime.Now;

            TimeSpan difference = dateTime - now;

            return difference.Days.ToString() + " den/dní";
        }

        public static DateTime GetUserDate(string message)
        {
            DateTime parsedDate;

            Console.WriteLine(message);
            while (!DateTime.TryParseExact(Console.ReadLine(), format, CultureInfo.CurrentCulture, DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine("Špatně napsaný formát. Zkuste to znovu!");
            };

            return parsedDate;
        }

        public static int GetIntInRange(string message)
        {
            int value;

            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Zadejte platné číslo.");
            }

            return value;
        }

        public static DateTime CalculateAddDays()
        {
            int daysToAdd = GetIntInRange("Napiš o kolik dní chcete čas posunout (+/-)");
            DateTime dateTime = GetUserDate("Napište datum ve formátu dd/MM/yyyy (např. 10/12/2024)");

            return dateTime.AddDays(daysToAdd);
        }

        public static string GetCurrentTime()
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            DateTime dateTime = DateTime.Now;

            return dateTime.ToString("HH:mm:ss", currentCulture);
        }
    }
}
