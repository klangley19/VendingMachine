using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public interface ICoin
    {
        int GetValueForNickel();
        int GetValueForDime();
        int GetValueForQuarter();

        int GetWeightForNickel();
        int GetWeightForDime();
        int GetWeightForQuarter();

        int GetSizeForNickel();
        int GetSizeForDime();
        int GetSizeForQuarter();

        bool DepositCoin(int CoinSize, int CoinWeight, out int Value);
        bool IsValidCoin(int size, int weight);




    }
}
