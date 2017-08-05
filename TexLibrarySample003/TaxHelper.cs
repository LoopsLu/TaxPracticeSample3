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

            if (income > 0)
                result += (r1 - r0) * f0;

            if (income > 0 && income <= 540000)
                result += (income - r1) * f1;

            var r2 = 540000m;
            var f2 = 0.12m;
            var r3 = 1210000m;
            var f3 = 0.2m;

            if (income > r2)
                result += (r2 - r1) * f1;

            if (income > r2 && income <= r3)
                result += (income - r2) * f2;

            if (income > r3)
                result += (r3 - r2) * f2;

            var r4 = 2420000;

            if (income > r3 && income <= r4)
                result += (income - r3) * f3;

            return result;
        }
    }
}
