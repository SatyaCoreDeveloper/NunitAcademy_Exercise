using NUnit.Framework;
using NunitAcademy.Core.DataDriven;

namespace NunitAcademy.Core.UnitTest.DataDriven.Tests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        [TestCase(1,2,2)]
        [TestCase(50, 25, 50)]
        public void Max_PositvieInputs_ExpectedMaxNumber(int input1, int input2, int expectedResult)
        {            
            var result = _math.Max(input1, input2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(50, 25, ExpectedResult = 50)]
        public int Max_PositvieInputs_RetunedMaxNumber(int input1, int input2)
        {            
            return _math.Max(input1, input2);            
        }

        [Test]
        [Sequential]
        public void Add_PostitiveInputs_ExpectedSum([Values(4,7,3)] int input1, 
                                                    [Values(6,8,24)] int intput2, 
                                                    [Values(10,15,27)] int expectedResult)
        {
            var result = _math.Add(input1, intput2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCaseSource(typeof(MathTestData), "MaxTestCase")]
        public void Max_SourceTestData_ExpectedMaxNumber(int input1, int input2, int expectedResult)
        {            
            var result = _math.Max(input1, input2);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCaseSource(typeof(MathTestData), "MaxTestCaseReturned")]
        public int Max_SourceTestData_ReturnedMaxNumber(int input1, int input2)
        {            
            return _math.Max(input1, input2);
        }

        [Test]
        public void getOddNumbers_PositiveLimit_OddNumbesTillLimit()
        {            
            var result = _math.GetOddNumbers(5);
            //Assert.IsNotNull(result);
            Assert.That(result, Does.Contain(3));
            Assert.That(result, Is.EquivalentTo(new[] { 1, 5, 3 }));
        }
    }
}
