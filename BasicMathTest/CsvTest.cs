using BasicMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathTest
{
    [TestClass]
    public class CsvTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv")]
        public void Test_AddMV()
        {
            BasicMaths bm = new BasicMaths();
            int a = Convert.ToInt32(TestContext.DataRow[0]);
            int b = Convert.ToInt32(TestContext.DataRow[1]);
            int expected = Convert.ToInt32(TestContext.DataRow[2]);
            double actual = bm.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void Test_SubstractMV()
        {
            BasicMaths bm = new BasicMaths();
            int a = Convert.ToInt32(TestContext.DataRow[4]);
            int b = Convert.ToInt32(TestContext.DataRow[5]);
            int expected = Convert.ToInt32(TestContext.DataRow[6]);
            double actual = bm.Substract(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void Test_DivideMV()
        {
            BasicMaths bm = new BasicMaths();
            int a = Convert.ToInt32(TestContext.DataRow[12]);
            int b = Convert.ToInt32(TestContext.DataRow[13]);
            int expected = Convert.ToInt32(TestContext.DataRow[14]);
            double actual = bm.Divide(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\Data.csv", "Data#csv", DataAccessMethod.Sequential), DeploymentItem("Data.csv"), TestMethod]
        public void Test_MultiplyMV()
        {
            BasicMaths bm = new BasicMaths();
            int a = Convert.ToInt32(TestContext.DataRow[8]);
            int b = Convert.ToInt32(TestContext.DataRow[9]);
            int expected = Convert.ToInt32(TestContext.DataRow[10]);
            double actual = bm.Multiply(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
