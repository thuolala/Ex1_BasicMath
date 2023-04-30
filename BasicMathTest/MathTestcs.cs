using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathTest
{
    [TestClass]
    public class MathTestcs
    {
        [TestMethod] 
        public void Test_Add() 
        { 
            var actual = MathHelper.Add(1, 2);
            var expected = 3;
            Assert.AreEqual(expected, actual);  
        }
    }

    public class MathHelper
    {
        public static int Add(int a, int b)
        { 
            return a + b; 
        }
    }
}
