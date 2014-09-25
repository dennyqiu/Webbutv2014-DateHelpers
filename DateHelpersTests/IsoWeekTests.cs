using System;
using System.Globalization;
using DateHelpers;
using Xunit;
using Xunit.Extensions;

namespace DateHelpersTests
{
    public class IsoWeekTests
    {
        [Theory]
        [InlineData("2007-01-01", "2007-W01")]
        [InlineData("2006-12-31", "2006-W52")]
        [InlineData("2009-01-01", "2009-W01")]
        [InlineData("2009-12-31", "2009-W53")]
        [InlineData("2008-12-31", "2009-W01")]
        [InlineData("2010-01-01", "2009-W53")]
        public void Iso_week_from_date(string date, string expectedIsoWeek)
        {
            var typedDate = DateTime.ParseExact(
                date,
                "yyyy-MM-dd",
                null,
                DateTimeStyles.None);

            var isoWeek = IsoWeekHelper.GetIsoWeek(typedDate);

            Assert.Equal(expectedIsoWeek, isoWeek);
        }
    }
}