using NUnit.Framework;

namespace RSA
{
    [TestFixture]
    class ByteNumberTests
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
        public void AddOperatorWorksCorrectly()
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
            Assert.AreEqual("0", (new ByteNumber("0") + new ByteNumber("0")).ToString());
        }

        [Test]
        public void SubOperatorWorksCorrectly()
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

        [Test]
        public void MultiplicationOperatorWorksCorrectly()
        {
            Assert.AreEqual("0", (new ByteNumber("0") * new ByteNumber("0")).ToString());
            Assert.AreEqual("0", (new ByteNumber("1") * new ByteNumber("0")).ToString());
            Assert.AreEqual("0", (new ByteNumber("0") * new ByteNumber("1")).ToString());
            Assert.AreEqual("1", (new ByteNumber("1") * new ByteNumber("1")).ToString());
            Assert.AreEqual("100", (new ByteNumber("10") * new ByteNumber("10")).ToString());
            Assert.AreEqual("-1", (new ByteNumber("1") * new ByteNumber("-1")).ToString());
            Assert.AreEqual("-1", (new ByteNumber("-1") * new ByteNumber("1")).ToString());
            Assert.AreEqual("123", (new ByteNumber("123") * new ByteNumber("1")).ToString());
            Assert.AreEqual("246420", (new ByteNumber("555") * new ByteNumber("444")).ToString());
            Assert.AreEqual("-133649026", (new ByteNumber("-386") * new ByteNumber("346241")).ToString());
            Assert.AreEqual("25", (new ByteNumber("-5") * new ByteNumber("-5")).ToString());
        }

        [Test]
        public void DivisionOperatorWorksCorrectly()
        {
            try
            {
                var division = new ByteNumber("1") / new ByteNumber("0");
                Assert.Fail();
            }
            catch { Assert.Pass(); }

            Assert.AreEqual("10", (new ByteNumber("0") / new ByteNumber("10")).ToString());
            Assert.AreEqual("10", (new ByteNumber("100") / new ByteNumber("10")).ToString());
            Assert.AreEqual("10", (new ByteNumber("100") / new ByteNumber("10")).ToString());
            Assert.AreEqual("-10", (new ByteNumber("-100") / new ByteNumber("10")).ToString());
            Assert.AreEqual("-10", (new ByteNumber("100") / new ByteNumber("-10")).ToString());
            Assert.AreEqual("99", (new ByteNumber("99") / new ByteNumber("1")).ToString());
            Assert.AreEqual("1", (new ByteNumber("99") / new ByteNumber("99")).ToString());
            Assert.AreEqual("11", (new ByteNumber("99") / new ByteNumber("9")).ToString());
            Assert.AreEqual("0", (new ByteNumber("5") / new ByteNumber("9")).ToString());
            Assert.AreEqual("3", (new ByteNumber("15") / new ByteNumber("4")).ToString());
            Assert.AreEqual("1473861", (new ByteNumber("346357457") / new ByteNumber("235")).ToString());
        }

        [Test]
        public void DivisionWithRemainderOperatorWorksCorrectly()
        {
            try
            {
                var division = new ByteNumber("1") % new ByteNumber("0");
                Assert.Fail();
            }
            catch { Assert.Pass(); }

            Assert.AreEqual("0", (new ByteNumber("100") % new ByteNumber("10")).ToString());
            Assert.AreEqual("0", (new ByteNumber("0") % new ByteNumber("1")).ToString());
            Assert.AreEqual("4", (new ByteNumber("11") % new ByteNumber("7")).ToString());
            Assert.AreEqual("4", (new ByteNumber("-11") % new ByteNumber("7")).ToString());
            Assert.AreEqual("4", (new ByteNumber("11") % new ByteNumber("-7")).ToString());
            Assert.AreEqual("4", (new ByteNumber("-11") % new ByteNumber("-7")).ToString());
            Assert.AreEqual("8242", (new ByteNumber("98235987235792") % new ByteNumber("23525")).ToString());
        }

        [Test]
        public void ComparisonOperatorsWorkCorrectly()
        {
            Assert.IsTrue(new ByteNumber("0") == new ByteNumber("0"));
            Assert.IsFalse(new ByteNumber("0") == new ByteNumber("1"));
            Assert.IsFalse(new ByteNumber("0") == new ByteNumber("-1"));
            Assert.IsFalse(new ByteNumber("-1") == new ByteNumber("1"));
            Assert.IsTrue(new ByteNumber("12345678901234567890") == new ByteNumber("12345678901234567890"));

            Assert.IsFalse(new ByteNumber("0") > new ByteNumber("0"));
            Assert.IsFalse(new ByteNumber("0") > new ByteNumber("1"));
            Assert.IsTrue(new ByteNumber("1") > new ByteNumber("0"));
            Assert.IsTrue(new ByteNumber("0") > new ByteNumber("-1"));
            Assert.IsTrue(new ByteNumber("1") > new ByteNumber("-1"));
            Assert.IsFalse(new ByteNumber("-1") > new ByteNumber("0"));
            Assert.IsFalse(new ByteNumber("-1") > new ByteNumber("0"));
            Assert.IsFalse(new ByteNumber("123456789") > new ByteNumber("987654321"));
            Assert.IsFalse(new ByteNumber("-39502850285") > new ByteNumber("98765"));
        }
    }

    [TestFixture]
    class RSATests
    {
        [Test]
        public void SimpleNumberIsCheckedCorrectly()
        {
            Assert.False(RSA.IsTheNumberSimple(0));
            Assert.False(RSA.IsTheNumberSimple(1));
            Assert.True(RSA.IsTheNumberSimple(2));
            Assert.True(RSA.IsTheNumberSimple(3));
            Assert.False(RSA.IsTheNumberSimple(4));
            Assert.True(RSA.IsTheNumberSimple(5));
            Assert.False(RSA.IsTheNumberSimple(6));
            Assert.True(RSA.IsTheNumberSimple(7));
            Assert.False(RSA.IsTheNumberSimple(8));
            Assert.False(RSA.IsTheNumberSimple(9));
            Assert.False(RSA.IsTheNumberSimple(10));
        }

        [Test]
        public void TextIsEncodedCorrectly()
        {
            Assert.AreEqual(0, RSA.Encode("", 3, 7).Count);

            var text = "sample text";
            var encodedText = RSA.Encode(text, 13, 17);
            Assert.AreEqual(text.Length, encodedText.Count);

            foreach (var encodedChar in encodedText)
                try { int.Parse(encodedChar); }
                catch { Assert.Fail(); }
        }

        [Test]
        public void TextIsDecodedCorrectly()
        {
            var text = "sample text";
            var p = 13;
            var q = 17;
            long n = p * q;
            long fi = (p - 1) * (q - 1);
            long e_ = RSA.Calculate_e(fi);
            long d = RSA.Calculate_d(e_, fi);
            var encodedText = RSA.Encode(text, e_, n);
            var decodedText = RSA.Decode(encodedText, d, n);
            Assert.AreEqual(text, decodedText);
        }

        [Test]
        public void Calculate_E_WorksCorrectly()
        {
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(8)));
            Assert.AreEqual(7, RSA.Calculate_e(8));
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(120)));
            Assert.AreEqual(113, RSA.Calculate_e(120));
            Assert.True(RSA.IsTheNumberSimple(RSA.Calculate_e(18000)));
            Assert.AreEqual(17989, RSA.Calculate_e(18000));
        }

        [Test]
        public void Calculate_D_WorksCorrectly()
        {
            Assert.AreEqual(7, RSA.Calculate_d(RSA.Calculate_e(8), 8));
            Assert.AreEqual(4361, RSA.Calculate_d(RSA.Calculate_e(10176), 10176));
            Assert.AreEqual(235, RSA.Calculate_d(RSA.Calculate_e(1176), 1176));
        }
    }
}
