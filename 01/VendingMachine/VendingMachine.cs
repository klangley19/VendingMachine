using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{

    #region public enum DispenseProductResult
    public enum DispenseProductResult
    {
        NotExactChangeMade,
        ProductNotAvailableInInventory,
        NotEnoughMoneyForProductDepositedInVendingMachine,
        DispenseProduct,
        Undefined
    }
    #endregion

    public class VendingMachine
    {
        
        //public class constructors
        #region public VendingMachine(ICoin Coin, IProduct Product)
        public VendingMachine(ICoin Coin, IProduct Product, IInventory Inventory)
        {
            if (Coin is Coin)
                this.Coin = Coin as Coin;
            else
                this.Coin = new Coin();

            if (Product is Product)
                this.Product = Product as Product;
            else
                this.Product = new Product();

            if (Inventory is Inventory)
                this.Inventory = Inventory as Inventory;
            else
                this.Inventory = new Inventory();


        }
        #endregion

        #region public VendingMachine()
        public VendingMachine()
        {
            this.Coin = new Coin();
            this.Product = new Product();
            this.Inventory = new Inventory();
        }
        #endregion


        //private member variables
        private Coin Coin;
        private Product Product;
        private Inventory Inventory;

        private Change ChangeInMachine = new Change();
        private Change LatestChangeMadeAfterPurchase = new Change();
        private string DisplayMessage = "INSERT COIN";
        private bool RequireExactChange = false;

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



        #region public Change LatestChangeMade
        //this property is here for testing, otherwise it is not needed
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


        //public class member functions
        #region public bool DepositCoin(int CoinSize, int CoinWeight)
        public bool DepositCoin(int CoinSize, int CoinWeight)
        {
            int CoinValue;

            try
            {
                bool returnValue = this.Coin.DepositCoin(CoinSize, CoinWeight, out CoinValue);
                if (returnValue)
                {
                    this.AddCoinToChangeInMachineObject(CoinValue);
                    this.UpdateDisplay();
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

        #region public bool Dispense(Products product)
        public bool Dispense(Products product)
        {
            try
            {
                bool returnValue = false;

                DispenseProductResult result = this.Inventory.DispenseProduct(product, this.Product, this.ChangeInMachine.ChangeInMachineValue, this.RequireExactChange);

                if (result == DispenseProductResult.NotExactChangeMade)
                {
                    this.DisplayMessage = "EXACT CHANGE ONLY";
                    returnValue = false;
                }
                else if (result == DispenseProductResult.ProductNotAvailableInInventory)
                {
                    this.DisplayMessage = "SOLD OUT";
                    returnValue = false;
                }
                else if (result == DispenseProductResult.NotEnoughMoneyForProductDepositedInVendingMachine)
                {
                    this.DisplayMessage = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(Product.GetTheCostForAProduct(product)) / 100m);
                    returnValue = false;
                }
                else if (result == DispenseProductResult.DispenseProduct)
                {
                    Change change = this.MakeChangeAfterPurchaseWasMade(product);
                    this.DispenseChange(change);
                    this.DisplayMessage = "THANK YOU";
                    returnValue = true;
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

        #region private Change MakeChangeAfterPurchaseWasMade(Products product)
        private Change MakeChangeAfterPurchaseWasMade(Products product)
        {
            decimal AmountOfChange = System.Convert.ToDecimal(this.ChangeInMachine.ChangeInMachineValue - Product.GetTheCostForAProduct(product))/100;
            Change change = new Change();
            change.MakeChange(AmountOfChange);
            return change;
        }
        #endregion
    }
}
