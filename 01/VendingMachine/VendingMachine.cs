﻿using System;
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
            try
            {
                bool returnValue = Product.Dispense(product, this.ValueInMachine);
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
