using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    #region public enum Products
    public enum Products
    {
        Candy = 0,
        Chips,
        Cola
    }
    #endregion

    public class Product : IProduct
    {

        #region private constants for the product cost
        private const int CandyCostAmount = 65;
        private const int ChipsCostAmount = 50;
        private const int ColaCostAmount = 100;
        #endregion

        #region private readonly member variables
        private readonly int CandyCost;
        private readonly int ChipsCost;
        private readonly int ColaCost;
        #endregion

        #region public Product()
        public Product()
        {
            this.CandyCost = CandyCostAmount;
            this.ChipsCost = ChipsCostAmount;
            this.ColaCost = ColaCostAmount;
        }
        #endregion



        #region public int GetCostForACola()
        public int GetCostForACola()
        {
            return this.ColaCost;
        }
        #endregion

        #region public int GetCostForACandy()
        public int GetCostForACandy()
        {
            return this.CandyCost;
        }
        #endregion

        #region public int GetCostForABagOfChips()
        public int GetCostForABagOfChips()
        {
            return this.ChipsCost;
        }
        #endregion


        #region public bool Dispense(Products product)
        public bool Dispense(Products product, int AmountInVendingMachine, out int ProductPrice, out Change change)
        {
            change = new Change();
            ProductPrice = this.GetTheCostForAProduct(product);

            if (AmountInVendingMachine >= ProductPrice)
            {
                AmountInVendingMachine -= ProductPrice;
                change = this.HandleMakingChangeAfterPurchase(AmountInVendingMachine);
                AmountInVendingMachine = 0;
                return true;
            }
            return false;

        }
        #endregion


        #region private Change HandleMakingChangeAfterPurchase(int Amount)
        private Change HandleMakingChangeAfterPurchase(int Amount)
        {
            Change change = new Change();
            decimal decimalAmount = System.Convert.ToDecimal(Amount) / 100m;
            change.MakeChange(decimalAmount);
            return change;
        }
        #endregion

        #region private int GetTheCostForAProduct(Products product)
        private int GetTheCostForAProduct(Products product)
        {
            if (product == Products.Cola)
            {
                return this.GetCostForACola();
            }
            else if (product == Products.Candy)
            {
                return this.GetCostForACandy();
            }
            else if (product == Products.Chips)
            {
                return this.GetCostForABagOfChips();
            }
            else
            {
                throw new ArgumentOutOfRangeException("The Dispense method was called without finding a matching product!");
            }

        }
        #endregion

    }
}
