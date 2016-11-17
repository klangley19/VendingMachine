using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

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


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Cola()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual("$0.80", vendingMachineMessage);
            Assert.AreEqual(80, vendingMacineValue);

        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Cola()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6, result7, result8, result9;
            bool productDispensed;
            string vendingMachineMessage;
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
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

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
            Assert.AreEqual("INSERT COIN", vendingMachineMessage);

        }


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Candy()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            bool productDispensed;
            string vendingMachineMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Candy);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual("$0.40", vendingMachineMessage);
            Assert.AreEqual(40, vendingMacineValue);

        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Candy()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Candy);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, productDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineMessage);

        }


        [TestMethod]
        public void Test_Not_Enough_Money_For_A_Chip_Bag()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            bool productDispensed;
            string vendingMachineMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual("$0.40", vendingMachineMessage);
            Assert.AreEqual(40, vendingMacineValue);

        }

        [TestMethod]
        public void Test_Enough_Money_For_A_Chip_Bag()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            int vendingMacineValue;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(true, productDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineMessage);

        }




    }
}
