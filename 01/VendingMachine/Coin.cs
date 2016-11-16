using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    #region public enum CoinValue
    public enum CoinValue
    {
        Undefined = 0,
        Nickel = 5,
        Dime = 10,
        Quarter = 25
    }
    #endregion

    #region public enum CoinWeight
    public enum CoinWeight
    {
        Undefined = 0,
        Nickel = 4,
        Dime = 2,
        Quarter = 5
    }
    #endregion

    #region public enum CoinSize
    public enum CoinSize
    {
        Undefined = 0,
        Nickel = 4,
        Dime = 2,
        Quarter = 5
    }
    #endregion

    public static class Coin
    {
        #region public static int GetValueForNickel()
        public static int GetValueForNickel()
        {
            return 5;
        }
        #endregion

        #region public static int GetValueForDime()
        public static int GetValueForDime()
        {
            return 10;
        }
        #endregion

        #region public static int GetValueForQuarter()
        public static int GetValueForQuarter()
        {
            return 25;
        }
        #endregion


        #region public static int GetWeightForNickel()
        public static int GetWeightForNickel()
        {
            return 4;
        }
        #endregion

        #region public static int GetWeightForDime()
        public static int GetWeightForDime()
        {
            return 2;
        }
        #endregion

        #region public static int GetWeightForQuarter()
        public static int GetWeightForQuarter()
        {
            return 5;
        }
        #endregion

        #region public static int GetSizeForNickel()
        public static int GetSizeForNickel()
        {
            return 4;
        }
        #endregion

        #region public static int GetSizeForDime()
        public static int GetSizeForDime()
        {
            return 2;
        }
        #endregion

        #region public static int GetSizeForQuarter()
        public static int GetSizeForQuarter()
        {
            return 5;
        }
        #endregion



    }
}
