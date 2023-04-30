using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BasicMath;

namespace BasicMathTest
{
    [TestClass]
    public class BasicMathTest
    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_AddMV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(12, 30, -18)]
        [DataRow(14, 1, 13)]
        public void Test_SubstractMV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Substract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 4, 3)]
        [DataRow(14, 1, 14)]
        public void Test_DivideMV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(12, 3, 36)]
        [DataRow(14, 1, 14)]
        public void Test_MultiplyMV(int a, int b, int expected)
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
