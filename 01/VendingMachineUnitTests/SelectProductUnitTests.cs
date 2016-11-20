using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class SelectProductUnitTests
    {
        Product Product = new Product();

        [TestMethod]
        public void Get_The_Cost_For_A_Cola_Is_Not_One_Dollar()
        {
            var productCost = this.Product.GetCostForACola();
            Assert.AreEqual(100, productCost);
        }

        [TestMethod]
        public void Get_The_Cost_For_A_Candy_Is_Not_Sixty_Five_Cents()
        {
            var productCost = this.Product.GetCostForACandy();
            Assert.AreEqual(65, productCost);
        }

        [TestMethod]
        public void Get_The_Cost_For_A_Bag_Of_Chips_Is_Not_FIfty_Cents()
        {
            var productCost = this.Product.GetCostForABagOfChips();
            Assert.AreEqual(50, productCost);
        }


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Cola()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            string vendingMachineMessageExpected;
            string vendingMachineFollowUpMessageExpected;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            vendingMachineMessageExpected = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(Product.GetCostForACola()) / 100m);
            vendingMachineFollowUpMessageExpected = string.Format("{0:C}", System.Convert.ToDecimal(vendingMacineValue) / 100m);


            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual(vendingMachineMessageExpected, vendingMachineMessage);
            Assert.AreEqual(80, vendingMacineValue);
            Assert.AreEqual(vendingMachineFollowUpMessageExpected, vendingMachineFollowUpMessage);

        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Cola()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6, result7, result8, result9;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            result7 = dependentClass.AddNickelToVendingMachine();
            result8 = dependentClass.AddDimeToVendingMachine();
            result9 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, result7);
            Assert.AreEqual(true, result8);
            Assert.AreEqual(true, result9);
            Assert.AreEqual(true, productDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineFollowUpMessage);

        }


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Candy()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            string vendingMachineMessageExpected;
            string vendingMachineFollowUpMessageExpected;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Candy);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            vendingMachineMessageExpected = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(Product.GetCostForACandy()) / 100m);
            vendingMachineFollowUpMessageExpected = string.Format("{0:C}", System.Convert.ToDecimal(vendingMacineValue) / 100m);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual(vendingMachineMessageExpected, vendingMachineMessage);
            Assert.AreEqual(40, vendingMacineValue);
            Assert.AreEqual(vendingMachineFollowUpMessageExpected, vendingMachineFollowUpMessage);

        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Candy()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Candy);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, productDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineFollowUpMessage);

        }


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Chip_Bag()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            string vendingMachineMessageExpected;
            string vendingMachineFollowUpMessageExpected;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            vendingMachineMessageExpected = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(Product.GetCostForABagOfChips()) / 100m);
            vendingMachineFollowUpMessageExpected = string.Format("{0:C}", System.Convert.ToDecimal(vendingMacineValue) / 100m);

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual(vendingMachineMessageExpected, vendingMachineMessage);
            Assert.AreEqual(40, vendingMacineValue);
            Assert.AreEqual(vendingMachineFollowUpMessageExpected, vendingMachineFollowUpMessage);


        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Chip_Bag()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, productDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineFollowUpMessage);

        }


        [TestMethod]
        public void Try_Buying_Something_With_Nothing_In_The_Vending_Machine()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            string vendingMachineMessageExpected;
            string vendingMachineFollowUpMessageExpected;

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            vendingMachineMessageExpected = "PRICE :: " + string.Format("{0:C}", System.Convert.ToDecimal(Product.GetCostForABagOfChips()) / 100m);
            vendingMachineFollowUpMessageExpected = "INSERT COIN";

            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual(vendingMachineMessageExpected, vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual(vendingMachineFollowUpMessageExpected, vendingMachineFollowUpMessage);


        }

    }
}
