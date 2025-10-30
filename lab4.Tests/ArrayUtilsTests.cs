using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace lab4.Tests
{
    [TestClass]
    public class ArrayUtilsTests
    {
        [TestMethod]
        public void FindMaxAbsolute_MixedValues_ReturnsCorrect()
        {
            double[] a = { -5.0, 3.2, -7.7, 7.6 };
            var res = lab4.ArrayUtils.FindMaxAbsolute(a);
            Assert.AreEqual(7.7, res, 1e-10);
        }

        [TestMethod]
        public void FindMaxAbsolute_AllNegative_ReturnsAbsMax()
        {
            double[] a = { -1.0, -2.5, -0.3 };
            var res = lab4.ArrayUtils.FindMaxAbsolute(a);
            Assert.AreEqual(2.5, res, 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FindMaxAbsolute_EmptyArray_Throws()
        {
            lab4.ArrayUtils.FindMaxAbsolute(new double[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FindMaxAbsolute_Null_Throws()
        {
            lab4.ArrayUtils.FindMaxAbsolute(null);
        }
    }
}
