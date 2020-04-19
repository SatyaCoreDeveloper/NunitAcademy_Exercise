using NUnit.Framework;
using NunitAcademy.Core.Advanced;
using System;

namespace NunitAcademy.Core.UnitTest.Advanced.Tests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        //[Test]
        //public void Log_onValidErrorMessage_ExpectedEvent_1()
        //{
        //    var logger = new ErrorLogger();
        //    var id = Guid.Empty;
        //    logger.ErrorLogged += (sender, args) => { id = args; };
        //    logger.Log("This is an Error");
        //    Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        //}

        [Test]
        public void Log_onValidErrorMessage_ExpectedEvent_2()
        {
            var logger = new ErrorLogger();
            var id = String.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };
            logger.Log("This is an Error");
            Assert.That(id, Is.EqualTo("This is an Error"));
        }
    }
}
