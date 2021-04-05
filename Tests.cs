using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RSA
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void ClassObjectHasCorrectNumber()
        {
            var input = "1234";
            var byteNumber = new ByteNumber(input);
            Assert.AreEqual(input, byteNumber.ToString());
        }

        [Test]
        public void ClassObjectHasCorrectSign()
        {
            var input = "5";
            var byteNumber = new ByteNumber(input);
            Assert.AreEqual(Sign.Positive, byteNumber.Sign);
            input = "-5";
            byteNumber = new ByteNumber(input);
            Assert.AreEqual(Sign.Negative, byteNumber.Sign);
        }

        [Test]
        public void SumOperatorWorksCorrectly()
        {
            Assert.AreEqual("-11", (new ByteNumber("-2") + new ByteNumber("-9")).ToString());
            Assert.AreEqual("2", (new ByteNumber("1") + new ByteNumber("1")).ToString());
            Assert.AreEqual("0", (new ByteNumber("-1") + new ByteNumber("1")).ToString());
            Assert.AreEqual("0", (new ByteNumber("1") + new ByteNumber("-1")).ToString());
            Assert.AreEqual("10", (new ByteNumber("1") + new ByteNumber("9")).ToString());
            Assert.AreEqual("9", (new ByteNumber("11") + new ByteNumber("-2")).ToString());
            Assert.AreEqual("9", (new ByteNumber("-2") + new ByteNumber("11")).ToString());
            Assert.AreEqual("-2", (new ByteNumber("-1") + new ByteNumber("-1")).ToString());
            Assert.AreEqual("-5", (new ByteNumber("-10") + new ByteNumber("5")).ToString());
            Assert.AreEqual("-5", (new ByteNumber("5") + new ByteNumber("-10")).ToString());
            Assert.AreEqual("1000", (new ByteNumber("999") + new ByteNumber("1")).ToString());
        }

        [Test]
        public void DifferenceOperatorWorksCorrectly()
        {
            Assert.AreEqual("0", (new ByteNumber("1") - new ByteNumber("1")).ToString());
            Assert.AreEqual("-2", (new ByteNumber("-1") - new ByteNumber("1")).ToString());
            Assert.AreEqual("0", (new ByteNumber("-1") - new ByteNumber("-1")).ToString());
            Assert.AreEqual("9", (new ByteNumber("10") - new ByteNumber("1")).ToString());
            Assert.AreEqual("-9", (new ByteNumber("1") - new ByteNumber("10")).ToString());
            Assert.AreEqual("-11", (new ByteNumber("-2") - new ByteNumber("9")).ToString());
            Assert.AreEqual("7", (new ByteNumber("9") - new ByteNumber("2")).ToString());
            Assert.AreEqual("999", (new ByteNumber("1000") - new ByteNumber("1")).ToString());
            Assert.AreEqual("1000", (new ByteNumber("999") - new ByteNumber("-1")).ToString());
        }
    }
}
