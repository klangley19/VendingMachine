using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class AcceptCoinUnitTest
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

            bool result = Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }


        [TestMethod]
        public void Coin_Deposited_Is_A_Dime()
        {
            var coinWeight = Coin.GetWeightForDime();
            var coinSize = Coin.GetSizeForDime();

            bool result = Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Coin_Deposited_Is_A_Quarter()
        {
            var coinWeight = Coin.GetWeightForQuarter();
            var coinSize = Coin.GetSizeForQuarter();

            bool result = Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }



        //[TestMethod]
        //public void Coin_Deposited_Is_A_Nickel()
        //{
        //    var coinWeight = Coin.GetWeightForNickel();
        //    var coinSize = Coin.GetSizeForNickel();

        //    bool result = Coin.IsValidCoin(CoinSize.Nickel, CoinWeight.Nickel);

        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void Coin_Deposited_Is_A_Dime()
        //{
        //    var coinWeight = Coin.GetWeightForNickel();
        //    var coinSize = Coin.GetSizeForNickel();

        //    bool result = Coin.IsValidCoin(CoinSize.Dime, CoinWeight.Dime);

        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void Coin_Deposited_Is_A_Quarter()
        //{
        //    var coinWeight = Coin.GetWeightForNickel();
        //    var coinSize = Coin.GetSizeForNickel();

        //    bool result = Coin.IsValidCoin(CoinSize.Quarter, CoinWeight.Quarter);

        //    Assert.AreEqual(true, result);
        //}


        //[TestMethod]
        //public void Coin_Deposited_Is_Not_A_Valid_Coin()
        //{

        //    #region coin checking algorithm
        //    //the vending machine will know the size and weight for the coin
        //    //and call the deposit coin method with these two values to resolve 
        //    //the size and weight to a possible matching coin

        //    //the DepositCoin method will evaluate the size to see if it matches
        //    //either a nickel, dime or quarter, and then it will evaluate the 
        //    //weight of the coin to see if that is a match with a nickel, dime or
        //    //quarter

        //    //if the size and weight match with a valid coin, then the IsValidCoin
        //    //is called with the size and weight enumerated values to ensure they
        //    //are of the same coin
        //    #endregion

        //    var coinSizeFromVendingMachine = 4;
        //    var coinWeightFromVendingMachine = 4;

        //    CoinSize coinSize = CoinSize.Undefined;
        //    CoinWeight coinWeight = CoinWeight.Undefined;


        //    if (coinSizeFromVendingMachine == Coin.GetSizeForNickel())
        //    {
        //        coinSize = CoinSize.Nickel;
        //    }
        //    else if (coinSizeFromVendingMachine == Coin.GetSizeForDime())
        //    {
        //        coinSize = CoinSize.Dime;
        //    }
        //    else if (coinSizeFromVendingMachine == Coin.GetSizeForQuarter())
        //    {
        //        coinSize = CoinSize.Quarter;
        //    }

        //    if (coinWeightFromVendingMachine == Coin.GetWeightForNickel())
        //    {
        //        coinSize = CoinSize.Nickel;
        //    }
        //    else if (coinWeightFromVendingMachine == Coin.GetWeightForDime())
        //    {
        //        coinSize = CoinSize.Dime;
        //    }
        //    else if (coinWeightFromVendingMachine == Coin.GetWeightForQuarter())
        //    {
        //        coinSize = CoinSize.Quarter;
        //    }



        //    //VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
        //    //bool coinDeposited = vm.DepositCoin(coinSize, coinWeight);

        //}


    }
}
