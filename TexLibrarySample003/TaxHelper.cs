using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexLibrarySample003
{
    public class TaxHelper
    {
        private static List<decimal> _r = new List<decimal>()
        { 0m, 0m, 540000m, 1210000m, 2420000m};

        private static List<decimal> _f = new List<decimal>()
        { 0m, 0.05m, 0.12m, 0.2m};

        public static decimal GetTaxResult(decimal income)
        {
            var result = 0m;

            for (int i = 1; i <= _f.Count; i++)
            {
                if (income > _r[i])
                    result += (_r[i] - _r[i - 1]) * _f[i - 1];

                if (income > _r[i] && income <= _r[i + 1])
                    result += (income - _r[i]) * _f[i];
            }

            return result;
        }
    }
}
