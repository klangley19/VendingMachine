using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

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
            
            var coinSizeFromVendingMachine = 4;
            var coinWeightFromVendingMachine = 4;

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(true, coinDeposited);
        }

        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin1()
        {

            var coinSizeFromVendingMachine = 10;
            var coinWeightFromVendingMachine = 10;

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(false, coinDeposited);
        }

        [TestMethod]
        public void Coin_Deposited_Is_Not_A_Valid_Coin2()
        {

            var coinSizeFromVendingMachine = Coin.GetSizeForNickel() + Coin.GetSizeForDime() + Coin.GetSizeForQuarter();
            var coinWeightFromVendingMachine = Coin.GetWeightForNickel() + Coin.GetWeightForDime() + Coin.GetWeightForQuarter();

            VendingMachine.VendingMachine vm = new VendingMachine.VendingMachine();
            bool coinDeposited = vm.DepositCoin(coinSizeFromVendingMachine, coinWeightFromVendingMachine);

            Assert.AreEqual(false, coinDeposited);
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

    }
}
