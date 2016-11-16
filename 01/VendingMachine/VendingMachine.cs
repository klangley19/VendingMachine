using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        #region public bool IsValidCoin(CoinSize size, CoinWeight weight)
        public bool IsValidCoin(CoinSize size, CoinWeight weight)
        {
            if (size == CoinSize.Nickel && weight == CoinWeight.Nickel)
            {
                return true;
            }
            else if (size == CoinSize.Dime && weight == CoinWeight.Dime)
            {
                return true;
            }
            else if (size == CoinSize.Quarter && weight == CoinWeight.Quarter)
            {
                return true;
            }
            return false;

        }
        #endregion



    }
}
