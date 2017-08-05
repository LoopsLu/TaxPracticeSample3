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
            
            if (income > _r[1])
                result += (_r[1] - _r[0]) * _f[0];

            if (income > _r[1] && income <= _r[2])
                result += (income - _r[1]) * _f[1];

            if (income > _r[2])
                result += (_r[2] - _r[1]) * _f[1];

            if (income > _r[2] && income <= _r[3])
                result += (income - _r[2]) * _f[2];

            if (income > _r[3])
                result += (_r[3] - _r[2]) * _f[2];

            if (income > _r[3] && income <= _r[4])
                result += (income - _r[3]) * _f[3];

            return result;
        }
    }
}
