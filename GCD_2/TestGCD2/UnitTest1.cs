using GCD_2;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestGCD2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEqual()
        {
            Assert.AreEqual(Euclid.GCD(1, 10), 1);
            Assert.AreEqual(Euclid.GCD(2, 10), 2);
            Assert.AreEqual(Euclid.GCD(121, 11), 11);
            Assert.AreEqual(Euclid.GCD(121, 33), 11);
            Assert.AreEqual(Euclid.GCD(121, 33), 11);
        }

        [TestMethod]
        public void TestMethodNOTEqual()
        {
            Assert.AreNotEqual(Euclid.GCD(1, 10), 5);
            Assert.AreNotEqual(Euclid.GCD(2, 10), 10);
            Assert.AreNotEqual(Euclid.GCD(121, 11), 121);
            Assert.AreNotEqual(Euclid.GCD(121, 33), 23);
        }

        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => { Euclid.GCD(0, 0); });
        }
    }
}