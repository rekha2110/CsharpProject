using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_1
{
    static class AppoinmentSchedular
    {
        public static void schedule(string date)
        {
            string[] newDate = date.Split('/', ' ', ':');
            Console.WriteLine("new DateTime" + " " + newDate[2] + ", " + newDate[0] + ", " + newDate[1]);
        }

        public static bool HasPassed(DateTime appointmentDate)
        {

            if (appointmentDate.Date >= DateTime.Now)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public static bool afternoon(DateTime timing)
        {
            string exactTime = timing.AddHours(24).ToString("tt", CultureInfo.InvariantCulture);
            if (exactTime == "PM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DateTime description(DateTime exactFormat)
        {
            CultureInfo regionTime = new CultureInfo("en-US");
            DateTime outputDate = DateTime.Parse(exactFormat.ToString("MM/dd/yyyy hh:mm tt"), regionTime);
            return outputDate;

        }
    }
}
 
