using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Value()
        {
            var coinValue = Coin.GetValueForNickel();
            Assert.AreEqual(5, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Value()
        {
            var coinValue = Coin.GetValueForDime();
            Assert.AreEqual(10, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Value()
        {
            var coinValue = Coin.GetValueForQuarter();
            Assert.AreEqual(25, coinValue);
        }


        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Weight()
        {
            var coinValue = Coin.GetWeightForNickel();
            Assert.AreEqual(4, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Weight()
        {
            var coinValue = Coin.GetWeightForDime();
            Assert.AreEqual(2, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Weight()
        {
            var coinValue = Coin.GetWeightForQuarter();
            Assert.AreEqual(5, coinValue);
        }


        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Size()
        {
            var coinValue = Coin.GetSizeForNickel();
            Assert.AreEqual(4, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Size()
        {
            var coinValue = Coin.GetSizeForDime();
            Assert.AreEqual(2, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Size()
        {
            var coinValue = Coin.GetSizeForQuarter();
            Assert.AreEqual(5, coinValue);
        }


        [TestMethod]
        public void Coin_Deposited_Is_A_Nickel()
        {
            var coinWeight = Coin.GetWeightForNickel();
            var coinSize = Coin.GetSizeForNickel();

            VendingMachine vm = new VendingMachine();
            bool result = vm.IsValidCoin(CoinSize.Nickel, CoinWeight.Nickel);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Coin_Deposited_Is_A_Dime()
        {
            var coinWeight = Coin.GetWeightForNickel();
            var coinSize = Coin.GetSizeForNickel();

            VendingMachine vm = new VendingMachine();
            bool result = vm.DepositCoin(CoinSize.Dime, CoinWeight.Dime);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Coin_Deposited_Is_A_Quarter()
        {
            var coinWeight = Coin.GetWeightForNickel();
            var coinSize = Coin.GetSizeForNickel();

            VendingMachine vm = new VendingMachine();
            bool result = vm.DepositCoin(CoinSize.Quarter, CoinWeight.Quarter);

            Assert.AreEqual(true, result);
        }



    }
}
