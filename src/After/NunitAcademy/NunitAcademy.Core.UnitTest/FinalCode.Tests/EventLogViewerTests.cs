using Moq;
using NUnit.Framework;
using NunitAcademy.Core.FinalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace NunitAcademy.Core.UnitTest.FinalCode.Tests
{
    [TestFixture]
    public class EventLogViewerTests
    {
        [Test]
        public void getEventsfromLast5Minutes_NoEvents_ExpectedEmptyList()
        {
            var mockWindowsEvents = new Mock<IEvents>();
            var eventLogViewer = new EventLogViewer(mockWindowsEvents.Object);
            mockWindowsEvents.Setup(win => win.getEventLogs(It.IsAny<DateTime>()))
                .Returns<ManagementObjectCollection>(null);

            var logs = eventLogViewer.getEventsfromLast5Minutes();
            Assert.That(logs.Count, Is.EqualTo(0));
        }

        [Test]
        public void getEventsfromLast5Minutes_ValidEvents_ExpectedEventList()
        {

        }

        [Test]
        public void getEventsfromLast5Minutes_ExceptionInConnection_ExpectedNull()
        {
            var mockWindowsEvents = new Mock<IEvents>();
            var eventLogViewer = new EventLogViewer(mockWindowsEvents.Object);
            mockWindowsEvents.Setup(win => win.getEventLogs(It.IsAny<DateTime>()))
                .Returns<ManagementObjectCollection>(null);

            var logs = eventLogViewer.getEventsfromLast5Minutes();
            Assert.IsNull(logs);
        }
    }
}
