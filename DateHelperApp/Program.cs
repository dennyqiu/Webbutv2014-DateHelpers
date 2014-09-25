using System;
using System.Collections.Generic;
using System.Linq;
using DateHelpers;

namespace DateHelperApp
{
    internal class Program
    {
        private static void Main()
        {
            var dates = GetRandomDates(1000);

            foreach (var date in dates.Take(10))
            {
                Console.Out.WriteLine("{0}, {1}", date, IsoWeekHelper.GetIsoWeek(date));
            }

            var weeks = dates
                .GroupBy(d => IsoWeekHelper.GetIsoWeek(d))
                .OrderBy(g => g.Key);

            foreach (var week in weeks.Take(10))
            {
                Console.Out.WriteLine("{0}, {1}", week.Key, week.Count());
            }

            var week23 = dates
                .GroupBy(d => IsoWeekHelper.GetIsoWeek(d))
                .Where(w => w.Key == "2008-W23");

            foreach (var datesInWeek23 in week23)
            {
                Console.Out.WriteLine("{0}", datesInWeek23.Key);

                foreach (var date in datesInWeek23)
                {
                    Console.Out.WriteLine("  {0}", date);
                }
            }

            /*
            var specialDate = DateTime.Today;
            var specialWeek = IsoWeekHelper.GetIsoWeek(specialDate);
            
            var week24 = stampings
                .Where(s => IsoWeekHelper.GetIsoWeek(s.Timestamp) == specialWeek);
            */

            Console.ReadKey();
        }

        public static List<DateTime> GetRandomDates(int count)
        {
            var baseDate = new DateTime(2000, 1, 1);
            var random = new Random();
            var list = new List<DateTime>();

            for (int i = 0; i < count; i++)
            {
                list.Add(baseDate.AddDays(random.Next(365 * 20)));
            }

            return list;
        }
    }
}