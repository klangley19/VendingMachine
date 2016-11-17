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
                string initialValue = this.DisplayMessage;
                this.UpdateDisplay();
                return initialValue;
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
                this.UpdateDisplay();
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
                int productPrice;
                bool returnValue = Product.Dispense(product, this.ValueInMachine, out productPrice);
                if (returnValue)
                {
                    this.ValueInMachine = 0;
                    this.DisplayMessage = "THANK YOU";
                }
                else
                {
                    this.DisplayMessage = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(productPrice) / 100m);
                }
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

        #region private void UpdateDisplay()
        private void UpdateDisplay()
        {
            

            if (this.DisplayMessage == "THANK YOU")
            {
                this.DisplayMessage = "INSERT COIN";
            }
            else if (this.DisplayMessage.IndexOf("PRICE") > -1)
            {                
                if (this.ValueInMachine > 0)
                {
                    this.DisplayMessage = this.GetDisplayOfValueInMacineAmount();
                }
                else
                {
                    this.DisplayMessage = "INSERT COIN";
                }
            }
            else
            {
                this.DisplayMessage = this.GetDisplayOfValueInMacineAmount();
            }
        }
        #endregion

        #region private string GetDisplayOfValueInMacineAmount()
        private string GetDisplayOfValueInMacineAmount()
        {
            decimal value;

            if (decimal.TryParse(ValueInMachine.ToString(), out value) == true)
            {
                return string.Format("{0:C}", value / 100);
            }
            else
            {
                throw new InvalidCastException("Error with getting the coin value being added to the vending machine to update the display!");
            }
        }
        #endregion

    }
}
