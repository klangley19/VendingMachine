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


        #region public int DepositedValueInMachine
        public int DepositedValueInMachine
        {
            get
            {
                return this.ValueInMachine;
            }
        }
        #endregion

        #region public string Display
        public string Display
        {
            get
            {
                return DisplayMessage;
            }
        }
        #endregion



        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            int CoinValue;

            try
            {
                bool returnValue = Coin.DepositCoin(CoinSize, CoinWeight, out CoinValue);
                this.ValueInMachine += CoinValue;
                this.UpdateDisplay(CoinValue);
                return returnValue;
            }
            catch (ArgumentOutOfRangeException e)
            {
                //TODO :: something useful like log the error instead of ignoring it
                return false;
            }
            catch (Exception e)
            {
                //TODO :: something useful like log the error instead of ignoring it
                return false;
            }
        }
        #endregion

        #region public bool Dispense(Products product)
        public bool Dispense(Products product)
        {
            if (product == Products.Cola)
            {
                if (this.ValueInMachine >= Product.GetCostForACola())
                {
                    this.ValueInMachine -= Product.GetCostForACola();
                    return true;
                }
                return false;
            }
            else if (product == Products.Candy)
            {
                if (this.ValueInMachine >= Product.GetCostForACandy())
                {
                    this.ValueInMachine -= Product.GetCostForACandy();
                    return true;
                }
                return false;
            }
            else if (product == Products.Chips)
            {
                if (this.ValueInMachine >= Product.GetCostForABagOfChips())
                {
                    this.ValueInMachine -= Product.GetCostForABagOfChips();
                    return true;
                }
                return false;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The Dispense method was called without finding a matching product!");
            }
        }
        #endregion

        #region private void UpdateDisplay(int Amount)
        private void UpdateDisplay(int Amount)
        {
            decimal value;
            if (decimal.TryParse(ValueInMachine.ToString(), out value) == true)
            {
                this.DisplayMessage = string.Format("{0:C}", value/100);
            }
            else
            {
                throw new InvalidCastException("Error with getting the coin value being added to the vending machine to update the display!");
            }

        }
        #endregion


    }
}
