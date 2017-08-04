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
            var result = 0m;

            var r0 = 0m;
            var r1 = 0m;
            var f0 = 0m;
            var f1 = 0.05m;

            if (income > 0 && income <= 540000)
                result += (r1 - r0) * f0 + (income - r1) * f1;

            var r2 = 540000m;
            var f2 = 0.12m;

            if (income > r2)
                result += (r2 - r1) * f1 + (income - r2) * f2;

            return result;
        }
    }
}
