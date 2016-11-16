using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class SelectProductUnitTests
    {
        [TestMethod]
        public void Get_The_Cost_For_A_Cola_Is_Not_One_Dollar()
        {
            var productCost = Product.GetCostForACola();
            Assert.AreEqual(100, productCost);
        }

        [TestMethod]
        public void Get_The_Cost_For_A_Candy_Is_Not_Sixty_Five_Cents()
        {
            var productCost = Product.GetCostForACandy();
            Assert.AreEqual(65, productCost);
        }

        [TestMethod]
        public void Get_The_Cost_For_A_Bag_Of_Chips_Is_Not_FIfty_Cents()
        {
            var productCost = Product.GetCostForABagOfChips();
            Assert.AreEqual(50, productCost);
        }

    }
}
