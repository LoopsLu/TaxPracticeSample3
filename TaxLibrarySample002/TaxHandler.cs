using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxLibrarySample002
{
    public abstract class TaxHandler
    {
         protected TaxHandler _nextHandler;
        public void SetNextHandler(TaxHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract decimal CalcTax(decimal income, decimal result); 
        
        protected decimal GetNextResult(decimal income, decimal result)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.CalcTax(income, result);
            }
            else
            {
                return result;
            }
        }
    }

    public class Level1TaxHandler : TaxHandler
    {
        public override decimal CalcTax(decimal income, decimal result)
        {            
            if (income > 0 && income <= 540000)
            {
                result += (income - 0) * 0.05m;
                return result;
            }
            else
            {
                if (income > 540000)
                {
                    result += (540000 - 0) * 0.05m;
                }
                return GetNextResult(income, result);
            }
        }
    }

    public class Level2TaxHandler : TaxHandler
    {
        public override decimal CalcTax(decimal income, decimal result)
        {
            if (income > 540000 && income <= 1210000)
            {
                result += (income - 540000) * 0.12m;
                return result;
            }
            else
            {
                if (income > 1210000)
                {
                    result += (1210000 - 540000) * 0.12m;
                }
                return GetNextResult(income, result);
            }
        }
    }

    public class Level3TaxHandler : TaxHandler
    {
        public override decimal CalcTax(decimal income, decimal result)
        {
            if (income > 1210000 && income <= 2420000)
            {
                result += (income - 1210000) * 0.2m;
                return result;
            }
            else
            {
                if (income > 2420000)
                {
                    result += (2420000 - 1210000) * 0.2m;
                }
                return GetNextResult(income, result);
            }
        }
    }

    public class Level4TaxHandler : TaxHandler
    {
        public override decimal CalcTax(decimal income, decimal result)
        {
            if (income > 2420000 && income <= 4530000)
            {
                result += (income - 2420000) * 0.3m;
                return result;
            }
            else
            {
                if (income > 4530000)
                {
                    result += (4530000 - 2420000) * 0.3m;
                }
                return GetNextResult(income, result);
            }
        }
    }

    public class Level5TaxHandler : TaxHandler
    {
        public override decimal CalcTax(decimal income, decimal result)
        {
            if (income > 4530000 && income <= 10310000)
            {
                result += (income - 4530000) * 0.4m;
                return result;
            }
            else
            {
                if (income > 10310000)
                {
                    result += (10310000 - 4530000) * 0.4m + (income - 10310000) * 0.5m;
                }
                return GetNextResult(income, result);
            }
        }
    }

  
}
