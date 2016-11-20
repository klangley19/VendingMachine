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

    public class Coin : ICoin
    {
        #region public int GetValueForNickel()
        public int GetValueForNickel()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinValue.Nickel);
        }
        #endregion

        #region public int GetValueForDime()
        public int GetValueForDime()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinValue.Dime);
        }
        #endregion

        #region public int GetValueForQuarter()
        public int GetValueForQuarter()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinValue.Quarter);
        }
        #endregion


        #region public int GetWeightForNickel()
        public int GetWeightForNickel()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinWeight.Nickel);
        }
        #endregion

        #region public int GetWeightForDime()
        public int GetWeightForDime()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinWeight.Dime);
        }
        #endregion

        #region public int GetWeightForQuarter()
        public int GetWeightForQuarter()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinWeight.Quarter);
        }
        #endregion


        #region public int GetSizeForNickel()
        public int GetSizeForNickel()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinSize.Nickel);
        }
        #endregion

        #region public int GetSizeForDime()
        public int GetSizeForDime()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinSize.Dime);
        }
        #endregion

        #region public int GetSizeForQuarter()
        public int GetSizeForQuarter()
        {
            return this.GetIntegerValueFromEnumeratedValue(CoinSize.Quarter);
        }
        #endregion


        #region private int GetIntegerValueFromEnumeratedValue(CoinValue Value)
        private int GetIntegerValueFromEnumeratedValue(CoinValue Value)
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

            return this.ParseIntegerFromString(strValue);

        }
        #endregion

        #region private int GetIntegerValueFromEnumeratedValue(CoinWeight Weight)
        private int GetIntegerValueFromEnumeratedValue(CoinWeight Weight)
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

            return this.ParseIntegerFromString(strValue);

        }
        #endregion

        #region private int GetIntegerValueFromEnumeratedValue(CoinSize Size)
        private int GetIntegerValueFromEnumeratedValue(CoinSize Size)
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

            return this.ParseIntegerFromString(strValue);

        }
        #endregion

        #region private int ParseIntegerFromString(string InputValue)
        private int ParseIntegerFromString(string InputValue)
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



        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight, out int Value)
        {
            Value = 0;
            if (this.IsValidCoin(CoinSize, CoinWeight))
            {
                if (CoinSize == this.GetSizeForNickel())
                {
                    Value = this.GetValueForNickel();
                    return true;
                }
                else if (CoinSize == this.GetSizeForDime())
                {
                    Value = this.GetValueForDime();
                    return true;
                }
                else if (CoinSize == this.GetSizeForQuarter())
                {
                    Value = this.GetValueForQuarter();
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A coin was considered valid but does not have a matching size for it!");
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region public bool IsValidCoin(int size, int weight)
        public bool IsValidCoin(int size, int weight)
        {
            if (size == this.GetSizeForNickel() && weight == this.GetWeightForNickel())
            {
                return true;
            }
            else if (size == this.GetSizeForDime() && weight == this.GetWeightForDime())
            {
                return true;
            }
            else if (size == this.GetSizeForQuarter() && weight == this.GetWeightForQuarter())
            {
                return true;
            }
            return false;

        }
        #endregion


    }
}
