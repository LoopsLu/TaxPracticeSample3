using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexLibrarySample003;

namespace TaxLibrarySample003Tests1
{
    [TestClass]
    public class TaxHelperTestsLoops
    {
        [TestMethod()]
        public void GetTaxResultTest_Income_100000_Tax_5000()
        {
            decimal income = 100000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 5000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_540000_Tax_27000()
        {
            decimal income = 540000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 27000;
            Assert.AreEqual(expected, actual);
        }
    }
}
