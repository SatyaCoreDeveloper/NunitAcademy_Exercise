using NUnit.Framework;
using NunitAcademy.Core.DataDriven;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAcademy.Core.UnitTest.DataDriven.Tests
{
    [TestFixture]
    public class UtilitiesTests
    {
        [Test]
        public void getFullName_validnames_ExpectedFullName()
        {
            var result = Utilities.getFullName("abc", "xyz");
            Assert.That(result, Does.StartWith("abc"));
            Assert.That(result, Does.EndWith("xyz"));
        }

        [Test]
        [Sequential]
        public void getDayOfWeek_ValidWeekdays_ExpectedNumber1to7([Values]Utilities.WeekDays weekDay,
            [Values(1, 2, 3, 4, 5, 6, 7)]int expectedValue)
        {
            var result = Utilities.getDayOfWeek(weekDay);
            Assert.That(result, Is.EqualTo(expectedValue));
        }

    }
}
