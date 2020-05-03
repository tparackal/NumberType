using NUnit.Framework;
using Num.Services;

namespace Num.UnitTests.Services
{
    [TestFixture]
    public class NumTypeTest
    {
        private NumType nType;

        [SetUp]
        public void SetUp()
        {
            nType = new NumType();
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void PosTest(int value)
        {
            var result = nType.isPos(value);
            Assert.IsTrue(result, $"{value} is not positive");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void NegTest(int value)
        {
            var result = nType.isNeg(value);
            Assert.IsTrue(result, $"{value} is not negative");
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        public void ZeroTest(int value)
        {
            var result = nType.isZero(value);
            Assert.IsTrue(result, $"{value} is not zero");
        }

        [Test]
        public void numTypeTest()
        {
            var result = nType.numType(23);
            Assert.AreEqual("positive", result, "This number is not positive");

        }
    }
}