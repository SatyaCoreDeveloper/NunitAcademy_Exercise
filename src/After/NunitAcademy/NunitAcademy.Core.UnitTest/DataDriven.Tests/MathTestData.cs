using NUnit.Framework;
using System.Collections;

namespace NunitAcademy.Core.UnitTest.DataDriven.Tests
{
    public class MathTestData
    {
        public static IEnumerable MaxTestCase
        {
            get
            {
                yield return new TestCaseData(1, 2, 2);
                yield return new TestCaseData(50, 25, 50);
            }
        }
        public static IEnumerable MaxTestCaseReturned
        {
            get
            {
                yield return new TestCaseData(1, 2).Returns(2);
                yield return new TestCaseData(50, 25).Returns(50);
            }
        }

        
    }
}
