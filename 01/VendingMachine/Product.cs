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

    public static class Product
    {

        #region private static readonly member variables
        private static readonly int CandyCost;
        private static readonly int ChipsCost;
        private static readonly int ColaCost;
        #endregion

        #region static Product()
        static Product()
        {
            Product.CandyCost = 65;
            Product.ChipsCost = 50;
            Product.ColaCost = 100;
        }
        #endregion



        #region public static int GetCostForACola()
        public static int GetCostForACola()
        {
            return Product.ColaCost;
        }
        #endregion

        #region public static int GetCostForACandy()
        public static int GetCostForACandy()
        {
            return Product.CandyCost;
        }
        #endregion

        #region public static int GetCostForABagOfChips()
        public static int GetCostForABagOfChips()
        {
            return Product.ChipsCost;
        }
        #endregion


        #region public static bool Dispense(Products product)
        public static bool Dispense(Products product, int AmountInVendingMachine, out int ProductPrice, out Change change)
        {
            change = new Change();
            ProductPrice = Product.GetTheCostForAProduct(product);

            if (AmountInVendingMachine >= ProductPrice)
            {
                AmountInVendingMachine -= ProductPrice;
                change = Product.HandleMakingChangeAfterPurchase(AmountInVendingMachine);
                AmountInVendingMachine = 0;
                return true;
            }
            return false;

        }
        #endregion


        #region private static Change HandleMakingChangeAfterPurchase(int Amount)
        private static Change HandleMakingChangeAfterPurchase(int Amount)
        {
            Change change = new Change();
            decimal decimalAmount = System.Convert.ToDecimal(Amount) / 100m;
            change.MakeChange(decimalAmount);
            return change;
        }
        #endregion

        #region private static int GetTheCostForAProduct(Products product)
        private static int GetTheCostForAProduct(Products product)
        {
            if (product == Products.Cola)
            {
                return Product.GetCostForACola();
            }
            else if (product == Products.Candy)
            {
                return Product.GetCostForACandy();
            }
            else if (product == Products.Chips)
            {
                return Product.GetCostForABagOfChips();
            }
            else
            {
                throw new ArgumentOutOfRangeException("The Dispense method was called without finding a matching product!");
            }

        }
        #endregion

    }
}
