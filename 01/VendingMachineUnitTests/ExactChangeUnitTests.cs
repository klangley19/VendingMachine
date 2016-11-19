using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class ExactChangeUnitTests
    {
        [TestMethod]
        public void TestDisplayWithoutExactChange()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            string display1, display2, display3, display4, display5, display6;
            string vendingMachineMessage1, vendingMachineMessage2;
            bool changeInVendingMachineReturned;


            vendingMachineMessage1 = dependentClass.GetVendingMachineDisplay();

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

            changeInVendingMachineReturned = dependentClass.ReturnChangeInVendingMachine();

            vendingMachineMessage2 = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual("INSERT COIN", vendingMachineMessage1);
            Assert.AreEqual("$0.05", display1);
            Assert.AreEqual("$0.10", display2);
            Assert.AreEqual("$0.20", display3);
            Assert.AreEqual("$0.30", display4);
            Assert.AreEqual("$0.55", display5);
            Assert.AreEqual("$0.80", display6);
            Assert.AreEqual(true, changeInVendingMachineReturned);
            Assert.AreEqual("INSERT COIN", vendingMachineMessage2);

        }

        [TestMethod]
        public void TestDisplayWithExactChange()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            string display1, display2, display3, display4, display5, display6;
            string vendingMachineMessage1, vendingMachineMessage2;


            dependentClass.SetExactChange(true);

            vendingMachineMessage1 = dependentClass.GetVendingMachineDisplay();

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

            dependentClass.ReturnChangeInVendingMachine();

            vendingMachineMessage2 = dependentClass.GetVendingMachineDisplay();

            Assert.AreEqual("EXACT CHANGE ONLY", vendingMachineMessage1);

            Assert.AreEqual("$0.05", display1);
            Assert.AreEqual("$0.10", display2);
            Assert.AreEqual("$0.20", display3);
            Assert.AreEqual("$0.30", display4);
            Assert.AreEqual("$0.55", display5);
            Assert.AreEqual("$0.80", display6);

            Assert.AreEqual("EXACT CHANGE ONLY", vendingMachineMessage2);

        }


        [TestMethod]
        public void TestDispenseProductWithExactChange()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4;
            bool ProductDispensed = false;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;


            dependentClass.SetExactChange(true);

            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();

            ProductDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            dependentClass.SetExactChange(false);

            //assert
            Assert.AreEqual(true, ProductDispensed);
            Assert.AreEqual("THANK YOU", vendingMachineMessage);
            Assert.AreNotEqual("INSERT COIN", vendingMachineFollowUpMessage);
            Assert.AreEqual("EXACT CHANGE ONLY", vendingMachineFollowUpMessage);
            Assert.AreEqual(0, vendingMacineValue);

        }


        [TestMethod]
        public void TestDoNotDispenseProductWithoutExactChange()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            bool ProductDispensed = false;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;


            dependentClass.SetExactChange(true);

            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddNickelToVendingMachine();

            ProductDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

            dependentClass.SetExactChange(false);

            //assert
            Assert.AreEqual(false, ProductDispensed);
            Assert.AreEqual("EXACT CHANGE ONLY", vendingMachineMessage);
            Assert.AreNotEqual("EXACT CHANGE ONLY", vendingMachineFollowUpMessage);
            Assert.AreEqual("$1.05", vendingMachineFollowUpMessage);
            Assert.AreEqual(105, vendingMacineValue);

        }



    }
}
