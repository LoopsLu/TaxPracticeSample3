using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TaxLibrarySample002
{
    /// <summary>
    /// 用責任鏈重構，這是一個不太好的想法
    /// </summary>
    public class TaxHelper
    {
       
        public static decimal GetTaxResult(decimal income)
        {
            var handler = CreateTaxHabdlersChain();
            decimal result = handler.CalcTax(income, 0);
            return result;
        }


        public static TaxHandler CreateTaxHabdlersChain()
        {
            TaxHandler handler1 = new Level1TaxHandler();
            TaxHandler handler2 = new Level2TaxHandler();
            TaxHandler handler3 = new Level3TaxHandler();
            TaxHandler handler4 = new Level4TaxHandler();
            TaxHandler handler5 = new Level5TaxHandler();
            handler1.SetNextHandler(handler2);
            handler2.SetNextHandler(handler3);
            handler3.SetNextHandler(handler4);
            handler4.SetNextHandler(handler5);

            return handler1;
        }
    }
}
