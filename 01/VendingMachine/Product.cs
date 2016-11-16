﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
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

    }
}