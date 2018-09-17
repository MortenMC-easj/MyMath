using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;

namespace MyMathDLLTest
{
    [TestClass]
    public class MathTest
    {
        MyMath m = new MyMath();
        [TestMethod]
        public void addTest()
        {

            Assert.IsTrue(m.Add(2, 3) == 5);
        }

        [TestMethod]

        public void addTestNegativeNumbers()
        {
            Assert.AreEqual(m.Add(-3, -4), -7);
        }
    }
}
