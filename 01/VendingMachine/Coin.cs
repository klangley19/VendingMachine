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
            return GetIntegerValueFromEnumeratedValue(CoinValue.Nickel);
        }
        #endregion

        #region public static int GetValueForDime()
        public static int GetValueForDime()
        {
            return GetIntegerValueFromEnumeratedValue(CoinValue.Dime);
        }
        #endregion

        #region public static int GetValueForQuarter()
        public static int GetValueForQuarter()
        {
            return GetIntegerValueFromEnumeratedValue(CoinValue.Quarter);
        }
        #endregion


        #region public static int GetWeightForNickel()
        public static int GetWeightForNickel()
        {
            return GetIntegerValueFromEnumeratedValue(CoinWeight.Nickel);
        }
        #endregion

        #region public static int GetWeightForDime()
        public static int GetWeightForDime()
        {
            return GetIntegerValueFromEnumeratedValue(CoinWeight.Dime);
        }
        #endregion

        #region public static int GetWeightForQuarter()
        public static int GetWeightForQuarter()
        {
            return GetIntegerValueFromEnumeratedValue(CoinWeight.Quarter);
        }
        #endregion


        #region public static int GetSizeForNickel()
        public static int GetSizeForNickel()
        {
            return GetIntegerValueFromEnumeratedValue(CoinSize.Nickel);
        }
        #endregion

        #region public static int GetSizeForDime()
        public static int GetSizeForDime()
        {
            return GetIntegerValueFromEnumeratedValue(CoinSize.Dime);
        }
        #endregion

        #region public static int GetSizeForQuarter()
        public static int GetSizeForQuarter()
        {
            return GetIntegerValueFromEnumeratedValue(CoinSize.Quarter);
        }
        #endregion


        #region private static int GetIntegerValueFromEnumeratedValue(CoinValue Value)
        private static int GetIntegerValueFromEnumeratedValue(CoinValue Value)
        {
            string strValue = string.Empty;
            if (Value == CoinValue.Nickel)
            {
                strValue = Enum.Format(typeof(CoinValue), CoinValue.Nickel, "d");
            }
            else if (Value == CoinValue.Dime)
            {
                strValue = Enum.Format(typeof(CoinValue), CoinValue.Dime, "d");
            }
            else if (Value == CoinValue.Quarter)
            {
                strValue = Enum.Format(typeof(CoinValue), CoinValue.Quarter, "d");
            }
            else
            {
                throw new ArgumentOutOfRangeException("The GetIntegerValueFromEnumeratedValue() was given an invalid argument");
            }

            return ParseIntegerFromString(strValue);

        }
        #endregion

        #region private static int GetIntegerValueFromEnumeratedValue(CoinWeight Weight)
        private static int GetIntegerValueFromEnumeratedValue(CoinWeight Weight)
        {
            string strValue = string.Empty;
            if (Weight == CoinWeight.Nickel)
            {
                strValue = Enum.Format(typeof(CoinWeight), CoinWeight.Nickel, "d");
            }
            else if (Weight == CoinWeight.Dime)
            {
                strValue = Enum.Format(typeof(CoinWeight), CoinWeight.Dime, "d");
            }
            else if (Weight == CoinWeight.Quarter)
            {
                strValue = Enum.Format(typeof(CoinWeight), CoinWeight.Quarter, "d");
            }
            else
            {
                throw new ArgumentOutOfRangeException("The GetIntegerValueFromEnumeratedValue() was given an invalid argument");
            }

            return ParseIntegerFromString(strValue);

        }
        #endregion

        #region private static int GetIntegerValueFromEnumeratedValue(CoinSize Size)
        private static int GetIntegerValueFromEnumeratedValue(CoinSize Size)
        {
            string strValue = string.Empty;
            if (Size == CoinSize.Nickel)
            {
                strValue = Enum.Format(typeof(CoinSize), CoinSize.Nickel, "d");
            }
            else if (Size == CoinSize.Dime)
            {
                strValue = Enum.Format(typeof(CoinSize), CoinSize.Dime, "d");
            }
            else if (Size == CoinSize.Quarter)
            {
                strValue = Enum.Format(typeof(CoinSize), CoinSize.Quarter, "d");
            }
            else
            {
                throw new ArgumentOutOfRangeException("The GetIntegerValueFromEnumeratedValue() was given an invalid argument");
            }

            return ParseIntegerFromString(strValue);

        }
        #endregion

        #region private static int ParseIntegerFromString(string InputValue)
        private static int ParseIntegerFromString(string InputValue)
        {
            int ReturnValue;
            if (int.TryParse(InputValue, out ReturnValue) == true)
            {
                return ReturnValue;
            }
            else
            {
                throw new InvalidCastException("Error trying to parse an integer from a string!");
            }
        }
        #endregion



        #region public static bool IsValidCoin(int size, int weight)
        public static bool IsValidCoin(int size, int weight)
        {
            if (size == GetSizeForNickel() && weight == GetWeightForNickel())
            {
                return true;
            }
            else if (size == GetSizeForDime() && weight == GetWeightForDime())
            {
                return true;
            }
            else if (size == GetSizeForQuarter() && weight == GetWeightForQuarter())
            {
                return true;
            }
            return false;

        }
        #endregion


    }
}
