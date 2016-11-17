﻿using System;
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
        public static bool Dispense(Products product, int AmountInVendingMachine)
        {
            if (product == Products.Cola)
            {
                if (AmountInVendingMachine >= Product.GetCostForACola())
                {
                    AmountInVendingMachine -= Product.GetCostForACola();
                    return true;
                }
                return false;
            }
            else if (product == Products.Candy)
            {
                if (AmountInVendingMachine >= Product.GetCostForACandy())
                {
                    AmountInVendingMachine -= Product.GetCostForACandy();
                    return true;
                }
                return false;
            }
            else if (product == Products.Chips)
            {
                if (AmountInVendingMachine >= Product.GetCostForABagOfChips())
                {
                    AmountInVendingMachine -= Product.GetCostForABagOfChips();
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


    }
}
