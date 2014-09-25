using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateHelpers
{
    public static class IsoWeekHelper
    {
        public static string GetIsoWeek(DateTime date)
        {
            var calendar = CultureInfo.InvariantCulture.Calendar;

            if (date.DayOfWeek >= DayOfWeek.Monday && date.DayOfWeek <= DayOfWeek.Wednesday)
            {
                date = date.AddDays(3);
            }

            var week = calendar.GetWeekOfYear(
                date,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);

            var year = date.Year;

            if (date.Month == 1 && week >= 52)
            {
                year -= 1;
            }

            return string.Format("{0}-W{1:00}", year, week);
        }
    }
}
