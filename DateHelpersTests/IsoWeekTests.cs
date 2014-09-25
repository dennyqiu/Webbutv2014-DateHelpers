using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateHelpers;
using Xunit;

namespace DateHelpersTests
{
    public class IsoWeekTests   
    {
        [Fact]
        public void First_of_january_2007_is_in_week_2007_W01()
        {
            var date = new DateTime(2007, 1, 1);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2007-W01", isoWeek);
        }

        [Fact]
        public void Last_of_december_2006_is_in_week_2006_W52()
        {
            var date = new DateTime(2006, 12, 31);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2006-W52", isoWeek);
        }

        [Fact]
        public void First_of_january_2009_is_in_week_2009_W01()
        {
            var date = new DateTime(2009, 1, 1);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2009-W01", isoWeek);
        }

        [Fact]
        public void Last_of_december_2009_is_in_week_2009_W53()
        {
            var date = new DateTime(2009, 12, 31);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2009-W53", isoWeek);
        }

        [Fact]
        public void Last_of_december_2008_is_in_week_2009_W01()
        {
            var date = new DateTime(2008, 12, 31);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2009-W01", isoWeek);
        }

        [Fact]
        public void First_of_january_2010_is_in_week_2009_W53()
        {
            var date = new DateTime(2010, 1, 1);

            var isoWeek = IsoWeekHelper.GetIsoWeek(date);

            Assert.Equal("2009-W53", isoWeek);
        }
    }
}
