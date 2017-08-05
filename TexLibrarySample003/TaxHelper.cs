using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexLibrarySample003
{
    public class TaxHelper
    {
        private static List<decimal> _incomeLevel = new List<decimal>()
        { 0m, 0m, 540000m, 1210000m, 2420000m, 4530000m, 10310000m, decimal.MaxValue};

        private static List<decimal> _taxRatio = new List<decimal>()
        { 0m, 0.05m, 0.12m, 0.2m, 0.3m, 0.4m, 0.5m};

        private static List<decimal> _incomeSum = new List<decimal>()
        { 0, 27000, 107400, 349400, 982400, 3294400};

        public static decimal GetTaxResult(decimal income)
        {
            var result = 0m;

            for (int i = 1; i < _taxRatio.Count; i++)
            {
                // 為了計算加速，可以把下面這段程式碼，事先計算出結果，
                // 並將結果存成_incomeSum(或存在文字檔、DB)，
                // 而這部分是固定不變的，不用每次重算；
                // 這樣子演算法就變成只要判斷區間，計算會變動的部分即可
                /*
                if (income > _incomeLevel[i])
                    result += (_incomeLevel[i] - _incomeLevel[i - 1]) * _taxRatio[i - 1];
                else
                    break;
                */

                if (income > _incomeLevel[i] && income <= _incomeLevel[i + 1])
                {
                    result += _incomeSum[i - 1];
                    result += (income - _incomeLevel[i]) * _taxRatio[i];
                    break;
                }
            }

            return result;
        }
    }
}
