using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {

        //private member variables
        private int ValueInMachine;
        private Change ChangeInMachine = new Change();
        private string DisplayMessage = "INSERT COIN";


        //public class properties
        #region public Change ChangeInVendingMachine
        public Change ChangeInVendingMachine
        {
            get { return this.ChangeInMachine; }
        }
        #endregion

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

        #region public Change LatestChangeMade
        public Change LatestChangeMade
        { get; private set; }
        #endregion


        //public class member functions
        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            int CoinValue;

            try
            {
                bool returnValue = Coin.DepositCoin(CoinSize, CoinWeight, out CoinValue);
                this.AddCoinToChangeInMachineObject(CoinValue);
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
                Change change;
                bool returnValue = Product.Dispense(product, this.ValueInMachine, out productPrice, out change);
                if (returnValue)
                {
                    this.DispenseChange(change);
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

        #region public bool ReturnChangeInVendingMachine()
        public bool ReturnChangeInVendingMachine()
        {
            try
            {
                this.DispenseChange(this.ChangeInMachine);
                return true;
            }
            catch (Exception e)
            {
                //TODO :: something useful like log the error instead of ignoring it
                return false;
            }

        }
        #endregion


        //private class member functions
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

        #region private void DispenseChange(Change c)
        private void DispenseChange(Change c)
        {
            //code here to tell machine how many quarters, 
            //how many dimes and how many nickels
            //to put into the coin return 

            //dispense ... c.Quarters
            //dispense ... c.Dimes
            //dispense ... c.Nickels

            this.LatestChangeMade = c;
            this.ChangeInMachine = new Change();
            return;
        }
        #endregion

        #region private void AddCoinToChangeInMachineObject(int CoinValue)
        private void AddCoinToChangeInMachineObject(int CoinValue)
        {
            if (CoinValue == 5)
                this.ChangeInMachine.Nickels++;
            else if (CoinValue == 10)
                this.ChangeInMachine.Dimes++;
            else if (CoinValue == 25)
                this.ChangeInMachine.Quarters++;
        }
        #endregion

    }
}
