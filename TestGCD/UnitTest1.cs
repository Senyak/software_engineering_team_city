using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GCD;

namespace TestGCD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodEqual()
        {
            Assert.AreEqual(Program.GCD(1, 10), 1);
            Assert.AreEqual(Program.GCD(2, 10), 2);
            Assert.AreEqual(Program.GCD(121, 11), 11);
            Assert.AreEqual(Program.GCD(121, 33), 11);
            Assert.AreEqual(Program.GCD(121, 33), 11);
        }

        [TestMethod]
        public void TestMethodNOTEqual()
        {
            Assert.AreNotEqual(Program.GCD(1, 10), 5);
            Assert.AreNotEqual(Program.GCD(2, 10), 10);
            Assert.AreNotEqual(Program.GCD(121, 11), 121);
            Assert.AreNotEqual(Program.GCD(121, 33), 23);
        }

        [TestMethod]
        public void TestMethodException()
        {
            Assert.ThrowsException<ArgumentException>(() => { Program.GCD(0, 0); });
        }
    }
}
