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
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinValue), CoinValue.Nickel, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the value for a nickel!");
            }
        }
        #endregion

        #region public static int GetValueForDime()
        public static int GetValueForDime()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinValue), CoinValue.Dime, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the value for a dime!");
            }
        }
        #endregion

        #region public static int GetValueForQuarter()
        public static int GetValueForQuarter()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinValue), CoinValue.Quarter, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the value for a quarter!");
            }
        }
        #endregion


        #region public static int GetWeightForNickel()
        public static int GetWeightForNickel()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinWeight), CoinWeight.Nickel, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the weight for a nickel!");
            }
        }
        #endregion

        #region public static int GetWeightForDime()
        public static int GetWeightForDime()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinWeight), CoinWeight.Dime, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the weight for a dime!");
            }
        }
        #endregion

        #region public static int GetWeightForQuarter()
        public static int GetWeightForQuarter()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinWeight), CoinWeight.Quarter, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the weight for a quarter!");
            }
        }
        #endregion


        #region public static int GetSizeForNickel()
        public static int GetSizeForNickel()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinSize), CoinSize.Nickel, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the size for a nickel!");
            }
        }
        #endregion

        #region public static int GetSizeForDime()
        public static int GetSizeForDime()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinSize), CoinSize.Dime, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the size for a dime!");
            }
        }
        #endregion

        #region public static int GetSizeForQuarter()
        public static int GetSizeForQuarter()
        {
            int value;
            if (int.TryParse(Enum.Format(typeof(CoinSize), CoinSize.Quarter, "d"), out value) == true)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Error with getting the size for a quarter!");
            }
        }
        #endregion



    }
}
