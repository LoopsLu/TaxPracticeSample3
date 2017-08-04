using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexLibrarySample003
{
    public class TaxHelper
    {
        public static decimal GetTaxResult(decimal income)
        {
            var r0 = 0m;
            var r1 = 0m;
            var f0 = 0m;
            var f1 = 0.05m;

            var result = (r1 - r0) * f0 + (income - r1) * f1;

            return result;
        }
    }
}
