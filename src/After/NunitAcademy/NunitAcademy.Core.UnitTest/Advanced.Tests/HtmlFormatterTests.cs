using NUnit.Framework;
using NunitAcademy.Core.Advanced;

namespace NunitAcademy.Core.UnitTest.Advanced.Tests
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_OnCalled_ExpectedValidHTML([Values("abc", "azy", "xyz")]string content)
        {
            var htmlFormatter = new HtmlFormatter();
            var result = htmlFormatter.FormatAsBold(content);
            //Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain(content).IgnoreCase);
        }
    }
}
