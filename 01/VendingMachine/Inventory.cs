using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{


    public class Inventory : IInventory
    {
        private const int InitialCandyInventory = 100;
        private const int InitialChipInventory = 100;
        private const int InitialColaInventory = 100;

        private int _candyQuantity = InitialCandyInventory;
        private int _chipQuantity = InitialChipInventory;
        private int _colaQuantity = InitialColaInventory;



        public int CandyQuantity
        {
            get { return this._candyQuantity; }
            set { this._candyQuantity = value; }
        }

        public int ChipQuantity
        {
            get { return this._chipQuantity; }
            set { this._chipQuantity = value; }
        }

        public int ColaQuantity
        {
            get { return this._colaQuantity; }
            set { this._colaQuantity = value; }
        }


        #region public Inventory()
        public Inventory()
        { }
        #endregion

        #region public Inventory(int CandyAmount, int ChipAmount, int ColaAmount)
        public Inventory(int CandyAmount, int ChipAmount, int ColaAmount)
        {
            this._candyQuantity = CandyAmount;
            this._chipQuantity = ChipAmount;
            this._colaQuantity = ColaAmount;
        }
        #endregion



        #region public DispenseProductResult DispenseProduct(Products ProductSelection, Product Product, int CentsDepositedInMachine, bool ExactChangeRequired)
        public DispenseProductResult DispenseProduct(Products ProductSelection, IProduct Product, int CentsDepositedInMachine, bool ExactChangeRequired)
        {
            int CostForTheProduct = Product.GetTheCostForAProduct(ProductSelection);

            if (this.ProductIsAvailableInInventory(ProductSelection) == false)
            {
                return DispenseProductResult.ProductNotAvailableInInventory;
            }
            else if (ExactChangeRequired == true)
            {
                if (CostForTheProduct != CentsDepositedInMachine)
                {
                    return DispenseProductResult.NotExactChangeMade;
                }
                else
                {
                    this.AdjustInventoryForProductDispensed(ProductSelection);
                    return DispenseProductResult.DispenseProduct;
                }
            }
            else if (CentsDepositedInMachine < CostForTheProduct)
            {
                return DispenseProductResult.NotEnoughMoneyForProductDepositedInVendingMachine;
            }
            else
            {
                this.AdjustInventoryForProductDispensed(ProductSelection);
                return DispenseProductResult.DispenseProduct;    
            }

        }
        #endregion



        #region private bool ProductIsAvailableInInventory(Products product)
        private bool ProductIsAvailableInInventory(Products product)
        {
            if (product == Products.Candy && this._candyQuantity > 0)
            {
                return true;
            }
            else if (product == Products.Chips && this._chipQuantity > 0)
            {
                return true;
            }
            else if (product == Products.Cola && this._colaQuantity > 0)
            {
                return true;
            }
            return false;

        }
        #endregion

        #region private void AdjustInventoryForProductDispensed(Products product)
        private void AdjustInventoryForProductDispensed(Products product)
        {
            if (product == Products.Candy)
            {
                this._candyQuantity--;
            }
            else if (product == Products.Chips)
            {
                this._chipQuantity--;
            }
            else if (product == Products.Cola)
            {
                this._colaQuantity--;
            }
        }
        #endregion

    }
    
}
