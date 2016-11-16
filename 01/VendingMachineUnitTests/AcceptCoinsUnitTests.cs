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


        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin()
        {

            #region coin checking algorithm
            //the vending machine will know the size and weight for the coin
            //and call the deposit coin method with these two values 

            //the method will validate the coin with the Coin.IsValidCoin() method

            //when the coin is determined to be valid, just need to match the 
            //size or weight back with a nickel, dime or quarter
            //to get the value for the coin

            //then with the value, update the value amount of coins in the
            //vending machine and the display for the machine
            #endregion

            var coinSizeFromVendingMachine = 4;
            var coinWeightFromVendingMachine = 4;

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(true, coinDeposited);
        }



        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Nickel_Deposited()
        {
            var coinSizeFromVendingMachine = Coin.GetSizeForNickel();
            var coinWeightFromVendingMachine = Coin.GetWeightForNickel();

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = vm.Display;

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.05", strVendingMachineDisplay);
        }

        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Dime_Deposited()
        {
            var coinSizeFromVendingMachine = Coin.GetSizeForDime();
            var coinWeightFromVendingMachine = Coin.GetWeightForDime();

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = vm.Display;

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.10", strVendingMachineDisplay);
        }

        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Quarter_Deposited()
        {
            var coinSizeFromVendingMachine = Coin.GetSizeForQuarter();
            var coinWeightFromVendingMachine = Coin.GetWeightForQuarter();

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = vm.Display;

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.25", strVendingMachineDisplay);
        }


    }
}
