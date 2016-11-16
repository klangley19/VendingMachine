using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        private int ValueInMachine;
        private string DisplayMessage = "INSERT COIN";

        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            if (Coin.IsValidCoin(CoinSize, CoinWeight))
            {
                if (CoinSize == Coin.GetSizeForNickel())
                {
                    ValueInMachine += Coin.GetValueForNickel();
                    return true;
                }
                else if (CoinSize == Coin.GetSizeForDime())
                {
                    ValueInMachine += Coin.GetValueForDime();
                    return true;
                }
                else if (CoinSize == Coin.GetSizeForQuarter())
                {
                    ValueInMachine += Coin.GetValueForQuarter();
                    return true;
                }
                return false;
            }
            else
            {
                //code here to send the invalid coin back in the coin return of the machine
                return false;
            }
        }
        #endregion


    }
}
