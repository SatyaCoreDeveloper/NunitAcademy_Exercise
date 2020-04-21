using NUnit.Framework;
using NunitAcademy.Core.FinalCode;
using System.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAcademy.Core.IntegrationTest.FinalCode.Tests
{
    [TestFixture]
    public class EventLogViewerTests
    {
        [Test]
        public void getEventsfromLast5Minutes_ValidEvents_ExpectedEventList()
        {
            var windowsEvents = new WindowsEvents(@"ROOT\CIMV2", new ConnectionOptions() {
                Impersonation = ImpersonationLevel.Impersonate,
                EnablePrivileges = true,
                Authentication = AuthenticationLevel.Packet
            });

            var eventlogViewer = new EventLogViewer(windowsEvents);
            var eventlogs = eventlogViewer.getEventsfromLast5Minutes();
            Assert.That(eventlogs.Count, Is.GreaterThan(0));
        }
    }
}
