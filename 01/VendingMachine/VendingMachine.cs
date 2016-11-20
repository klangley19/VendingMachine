using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine
    {
        
        //public class constructors
        #region public VendingMachine(ICoin Coin, IProduct Product)
        public VendingMachine(ICoin Coin, IProduct Product)
        {
            if (Coin is Coin)
                this.Coin = Coin as Coin;
            else
                this.Coin = new Coin();

            if (Product is Product)
                this.Product = Product as Product;
            else
                this.Product = new Product();

        }
        #endregion

        #region public VendingMachine()
        public VendingMachine()
        {
            this.Coin = new Coin();
            this.Product = new Product();
        }
        #endregion


        //private member variables
        Coin Coin;
        Product Product;

        private Change ChangeInMachine = new Change();
        private Change LatestChangeMadeAfterPurchase = new Change();
        private string DisplayMessage = "INSERT COIN";
        private Inventory CurrentInventoryLevel = new Inventory();
        private bool RequireExactChange = false;

        //public class properties
        #region public Change ChangeInVendingMachine
        public Change ChangeInVendingMachine
        {
            get { return this.ChangeInMachine; }
        }
        #endregion

        #region public Change LatestChangeMade
        public Change LatestChangeMade
        {
            get
            {
                return this.LatestChangeMadeAfterPurchase;
            }
            private set
            {
                this.LatestChangeMadeAfterPurchase = value;
            }
        }
        #endregion


        #region public int DepositedValueInMachine
        public int DepositedValueInMachine
        {
            get
            {
                return this.ChangeInMachine.ChangeInMachineValue;
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

        #region public Inventory InventoryInVendingMachine
        public Inventory InventoryInVendingMachine
        {
            get { return this.CurrentInventoryLevel; }
            set { this.CurrentInventoryLevel = value; }
        }
        #endregion

        #region public bool RequireExactChangeForPurchase
        public bool RequireExactChangeForPurchase
        {
            get
            {
                return this.RequireExactChange;
            }
            set
            {
                this.RequireExactChange = value;
                if (this.DisplayMessage == "INSERT COIN" && this.RequireExactChange)
                {
                    this.DisplayMessage = "EXACT CHANGE ONLY";
                }
                else if (this.DisplayMessage == "EXACT CHANGE ONLY" && (this.RequireExactChange == false))
                {
                    this.DisplayMessage = "INSERT COIN";
                }

            }
        }
        #endregion


        //public class member functions
        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            int CoinValue;

            try
            {
                bool returnValue = this.Coin.DepositCoin(CoinSize, CoinWeight, out CoinValue);
                this.AddCoinToChangeInMachineObject(CoinValue);
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
                bool returnValue;
                int productPrice;
                Change change;

                //first check inventory to be sure we have it
                if (this.CheckInventoryForProductToDispense(product) == false)
                {
                    this.DisplayMessage = "SOLD OUT";
                    returnValue = false;
                }
                else if (this.MakeSureExactAmountIsDepositedIfRequired(product) == false)
                {
                    this.DisplayMessage = "EXACT CHANGE ONLY";
                    returnValue = false;
                }
                else
                {
                    returnValue = this.Product.Dispense(product, this.ChangeInMachine.ChangeInMachineValue, out productPrice, out change);
                    if (returnValue)
                    {
                        this.AdjustInventoryForProductToDispense(product);
                        this.DispenseChange(change);
                        this.DisplayMessage = "THANK YOU";
                    }
                    else
                    {
                        this.DisplayMessage = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(productPrice) / 100m);
                    }
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
                this.UpdateDisplay();
                return true;
            }
            catch (Exception e)
            {
                //TODO :: something useful like log the error instead of ignoring it
                return false;
            }

        }
        #endregion



        //private class member functions - helper methods
        #region private void UpdateDisplay()
        private void UpdateDisplay()
        {
            

            if (this.DisplayMessage == "THANK YOU")
            {
                this.DisplayMessage = this.DisplayInitialMessage();
            }
            else
            {
                if (this.ChangeInMachine.ChangeInMachineValue > 0)
                {
                    this.DisplayMessage = this.GetDisplayOfValueInMacineAmount();
                }
                else
                {
                    this.DisplayMessage = this.DisplayInitialMessage();
                }
            }
        }
        #endregion

        #region private string GetDisplayOfValueInMacineAmount()
        private string GetDisplayOfValueInMacineAmount()
        {
            decimal value;

            if (decimal.TryParse(this.ChangeInMachine.ChangeInMachineValue.ToString(), out value) == true)
            {
                return string.Format("{0:C}", value / 100);
            }
            else
            {
                throw new InvalidCastException("Error with getting the coin value being added to the vending machine to update the display!");
            }
        }
        #endregion

        #region private string DisplayInitialMessage()
        private string DisplayInitialMessage()
        {
            if (this.RequireExactChange)
                return "EXACT CHANGE ONLY";
            else
                return "INSERT COIN";
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
            if (CoinValue == this.Coin.GetValueForNickel())
                this.ChangeInMachine.Nickels++;
            else if (CoinValue == this.Coin.GetValueForDime())
                this.ChangeInMachine.Dimes++;
            else if (CoinValue == this.Coin.GetValueForQuarter())
                this.ChangeInMachine.Quarters++;
        }
        #endregion

        #region private bool CheckInventoryForProductToDispense(Products product)
        private bool CheckInventoryForProductToDispense(Products product)
        {
            if (product == Products.Candy && this.InventoryInVendingMachine.CandyQuantity > 0)
            {
                return true;
            }
            else if (product == Products.Chips && this.InventoryInVendingMachine.ChipQuantity > 0)
            {
                return true;
            }
            else if (product == Products.Cola && this.InventoryInVendingMachine.ColaQuantity > 0)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region private void AdjustInventoryForProductToDispense(Products product)
        private void AdjustInventoryForProductToDispense(Products product)
        {
            if (product == Products.Candy)
            {
                this.InventoryInVendingMachine.CandyQuantity--;
            }
            else if (product == Products.Chips)
            {
                this.InventoryInVendingMachine.ChipQuantity--;
            }
            else if (product == Products.Cola)
            {
                this.InventoryInVendingMachine.ColaQuantity--;
            }
            return;

        }
        #endregion

        #region private bool MakeSureExactAmountIsDepositedIfRequired(Products product)
        private bool MakeSureExactAmountIsDepositedIfRequired(Products product)
        {
            if (this.RequireExactChange == false)
            {
                return true;
            }
            else if (product == Products.Candy)
            {
                if (this.Product.GetCostForACandy() == this.ChangeInMachine.ChangeInMachineValue)
                    return true;
            }
            else if (product == Products.Chips)
            {
                if (this.Product.GetCostForABagOfChips() == this.ChangeInMachine.ChangeInMachineValue)
                    return true;
            }
            else if (product == Products.Cola)
            {
                if (this.Product.GetCostForACola() == this.ChangeInMachine.ChangeInMachineValue)
                    return true;
            }
            return false;

        }
        #endregion
    }
}
