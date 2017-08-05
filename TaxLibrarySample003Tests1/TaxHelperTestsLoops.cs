using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexLibrarySample003;
using System.Collections.Generic;

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

        [TestMethod()]
        public void GetTaxResultTest_Income_540001_Tax_27000p12()
        {
            decimal income = 540001;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 27000.12m;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_1210000_Tax_107400()
        {
            decimal income = 1210000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 107400;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_1218000_Tax_109000()
        {
            decimal income = 1218000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 109000;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetTaxResultTest_Income_2420000_Tax_349400()
        {
            decimal income = 2420000;
            decimal actual = TaxHelper.GetTaxResult(income);
            decimal expected = 349400;
            Assert.AreEqual(expected, actual);
        }
    }
}
