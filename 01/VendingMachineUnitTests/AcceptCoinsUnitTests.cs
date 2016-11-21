using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class AcceptCoinUnitTest
    {
        private Coin Coin = new Coin();

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Value()
        {
            var coinValue = this.Coin.GetValueForNickel();
            Assert.AreEqual(5, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Value()
        {
            var coinValue = this.Coin.GetValueForDime();
            Assert.AreEqual(10, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Value()
        {
            var coinValue = this.Coin.GetValueForQuarter();
            Assert.AreEqual(25, coinValue);
        }


        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Weight()
        {
            var coinValue = this.Coin.GetWeightForNickel();
            Assert.AreEqual(4, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Weight()
        {
            var coinValue = this.Coin.GetWeightForDime();
            Assert.AreEqual(2, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Weight()
        {
            var coinValue = this.Coin.GetWeightForQuarter();
            Assert.AreEqual(5, coinValue);
        }


        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Nickel_Size()
        {
            var coinValue = this.Coin.GetSizeForNickel();
            Assert.AreEqual(4, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Dime_Size()
        {
            var coinValue = this.Coin.GetSizeForDime();
            Assert.AreEqual(2, coinValue);
        }

        [TestMethod]
        public void A_Coin_Does_Not_Have_A_Quarter_Size()
        {
            var coinValue = this.Coin.GetSizeForQuarter();
            Assert.AreEqual(5, coinValue);
        }


        [TestMethod]
        public void Coin_Deposited_Is_A_Nickel()
        {
            var coinWeight = this.Coin.GetWeightForNickel();
            var coinSize = this.Coin.GetSizeForNickel();

            bool result = this.Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Coin_Deposited_Is_A_Dime()
        {
            var coinWeight = this.Coin.GetWeightForDime();
            var coinSize = this.Coin.GetSizeForDime();

            bool result = this.Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Coin_Deposited_Is_A_Quarter()
        {
            var coinWeight = this.Coin.GetWeightForQuarter();
            var coinSize = this.Coin.GetSizeForQuarter();

            bool result = this.Coin.IsValidCoin(coinSize, coinWeight);

            Assert.AreEqual(true, result);
        }



        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = 4;
            var coinWeightFromVendingMachine = 4;

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(true, coinDeposited);
        }

        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin1()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = 10;
            var coinWeightFromVendingMachine = 10;

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(false, coinDeposited);
        }

        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin2()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = this.Coin.GetSizeForNickel() + this.Coin.GetSizeForDime() + this.Coin.GetSizeForQuarter();
            var coinWeightFromVendingMachine = this.Coin.GetWeightForNickel() + this.Coin.GetWeightForDime() + this.Coin.GetWeightForQuarter();

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(false, coinDeposited);
        }


        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Nickel_Deposited()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = this.Coin.GetSizeForNickel();
            var coinWeightFromVendingMachine = this.Coin.GetWeightForNickel();

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.05", strVendingMachineDisplay);
        }

        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Dime_Deposited()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = this.Coin.GetSizeForDime();
            var coinWeightFromVendingMachine = this.Coin.GetWeightForDime();

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.10", strVendingMachineDisplay);
        }

        [TestMethod]
        public void Display_Is_Not_Set_Right_For_A_Quarter_Deposited()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            var coinSizeFromVendingMachine = this.Coin.GetSizeForQuarter();
            var coinWeightFromVendingMachine = this.Coin.GetWeightForQuarter();

            bool coinDeposited = dependentClass.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);
            string strVendingMachineDisplay = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual(true, coinDeposited);
            Assert.AreEqual("$0.25", strVendingMachineDisplay);
        }




        [TestMethod]
        public void Display_Does_Not_Initially_Say_Insert_Coin()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            string vendingMachineMessage;
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            Assert.AreEqual("INSERT COIN", vendingMachineMessage);

        }

        [TestMethod]
        public void Display_Does_Not_Update_Correctly_When_A_Valid_Coin_Is_Added_To_The_Vending_Machine()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            string vendingMachineInitialMessage;
            bool result1, result2, result3, result4, result5, result6;
            string display1, display2, display3, display4, display5, display6;



            vendingMachineInitialMessage = dependentClass.GetVendingMachineDisplay();

            result1 = dependentClass.AddNickelToVendingMachine();
            display1 = dependentClass.GetVendingMachineDisplay();

            result2 = dependentClass.AddNickelToVendingMachine();
            display2 = dependentClass.GetVendingMachineDisplay();

            result3 = dependentClass.AddDimeToVendingMachine();
            display3 = dependentClass.GetVendingMachineDisplay();

            result4 = dependentClass.AddDimeToVendingMachine();
            display4 = dependentClass.GetVendingMachineDisplay();

            result5 = dependentClass.AddQuarterToVendingMachine();
            display5 = dependentClass.GetVendingMachineDisplay();

            result6 = dependentClass.AddQuarterToVendingMachine();
            display6 = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual("INSERT COIN", vendingMachineInitialMessage);
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual("$0.05", display1);
            Assert.AreEqual("$0.10", display2);
            Assert.AreEqual("$0.20", display3);
            Assert.AreEqual("$0.30", display4);
            Assert.AreEqual("$0.55", display5);
            Assert.AreEqual("$0.80", display6);
        }

        [TestMethod]
        public void Value_For_Money_In_Vending_Machine_When_Coin_Added_Not_Updated()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            string vendingMachineInitialMessage;
            bool result1, result2, result3, result4, result5, result6;
            int value1, value2, value3, value4, value5, value6;



            vendingMachineInitialMessage = dependentClass.GetVendingMachineDisplay();

            result1 = dependentClass.AddNickelToVendingMachine();
            value1 = dependentClass.GetVendingMachineCoinValueInCents();

            result2 = dependentClass.AddNickelToVendingMachine();
            value2 = dependentClass.GetVendingMachineCoinValueInCents();

            result3 = dependentClass.AddDimeToVendingMachine();
            value3 = dependentClass.GetVendingMachineCoinValueInCents();

            result4 = dependentClass.AddDimeToVendingMachine();
            value4 = dependentClass.GetVendingMachineCoinValueInCents();

            result5 = dependentClass.AddQuarterToVendingMachine();
            value5 = dependentClass.GetVendingMachineCoinValueInCents();

            result6 = dependentClass.AddQuarterToVendingMachine();
            value6 = dependentClass.GetVendingMachineCoinValueInCents();

            Assert.AreEqual("INSERT COIN", vendingMachineInitialMessage);
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(5, value1);
            Assert.AreEqual(10, value2);
            Assert.AreEqual(20, value3);
            Assert.AreEqual(30, value4);
            Assert.AreEqual(55, value5);
            Assert.AreEqual(80, value6);
        }

        [TestMethod]
        public void Be_Sure_When_An_Invalid_Coin_Is_Attempted_To_Be_Inserted_That_Display_And_Value_In_Vending_Machine_Stay_The_Same()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool coinDeposited;
            bool result1, result2, result3, result4, result5, result6;
            string vendingMachineMessageBeforeInvalidCoinDeposit;
            string vendingMachineMessageAfterInvalidCoinDeposit;
            int vendingMacineValueBeforeInvalidCoinDeposit;
            int vendingMacineValueAfterInvalidCoinDeposit;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            vendingMachineMessageBeforeInvalidCoinDeposit = dependentClass.GetVendingMachineDisplay();
            vendingMacineValueBeforeInvalidCoinDeposit = dependentClass.GetVendingMachineCoinValueInCents();


            coinDeposited = dependentClass.DepositCoin(67, 85);

            vendingMachineMessageAfterInvalidCoinDeposit = dependentClass.GetVendingMachineDisplay();
            vendingMacineValueAfterInvalidCoinDeposit = dependentClass.GetVendingMachineCoinValueInCents();

            Assert.AreEqual(vendingMachineMessageBeforeInvalidCoinDeposit, vendingMachineMessageAfterInvalidCoinDeposit);
            Assert.AreEqual(vendingMacineValueBeforeInvalidCoinDeposit, vendingMacineValueAfterInvalidCoinDeposit);

        }

    }
}
