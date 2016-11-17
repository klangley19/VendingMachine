using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class SoldOutUnitTests
    {

        [TestMethod]
        public void CheckInitialInventoryLevelsInTheVendingMachine()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            Inventory i = dependentClass.GetInventoryLevels();

            Assert.AreEqual(10, i.CandyQuantity);
            Assert.AreEqual(10, i.ChipQuantity);
            Assert.AreEqual(10, i.ColaQuantity);

        }

        [TestMethod]
        public void CheckChangingInventoryLevelsInTheVendingMachine()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            Inventory i = dependentClass.GetInventoryLevels();

            i.CandyQuantity = 1;
            i.ChipQuantity = 1;
            i.ColaQuantity = 1;
            dependentClass.SetInventoryLevels(i);

            Assert.AreEqual(1, i.CandyQuantity);
            Assert.AreEqual(1, i.ChipQuantity);
            Assert.AreEqual(1, i.ColaQuantity);

        }

        [TestMethod]
        public void Buy_Cola_And_Check_Inventory_Level_Going_Down_By_One()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            Inventory presale_inventory_level;
            Inventory postsale_inventory_level;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            presale_inventory_level = dependentClass.GetInventoryLevels();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            postsale_inventory_level = dependentClass.GetInventoryLevels();

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

            Assert.AreEqual(presale_inventory_level.CandyQuantity, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(presale_inventory_level.ChipQuantity, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(presale_inventory_level.ColaQuantity - 1, postsale_inventory_level.ColaQuantity);
        }

        [TestMethod]
        public void Buy_Bag_Of_Chips_And_Check_Inventory_Level_Going_Down_By_One()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            Inventory presale_inventory_level;
            Inventory postsale_inventory_level;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            presale_inventory_level = dependentClass.GetInventoryLevels();

            productDispensed = dependentClass.Dispense(Products.Chips);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            postsale_inventory_level = dependentClass.GetInventoryLevels();

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

            Assert.AreEqual(presale_inventory_level.CandyQuantity, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(presale_inventory_level.ChipQuantity - 1, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(presale_inventory_level.ColaQuantity, postsale_inventory_level.ColaQuantity);




        }

        [TestMethod]
        public void Buy_Candy_And_Check_Inventory_Level_Going_Down_By_One()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            Inventory presale_inventory_level;
            Inventory postsale_inventory_level;

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            presale_inventory_level = dependentClass.GetInventoryLevels();

            productDispensed = dependentClass.Dispense(Products.Candy);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            postsale_inventory_level = dependentClass.GetInventoryLevels();

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

            Assert.AreEqual(presale_inventory_level.CandyQuantity - 1, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(presale_inventory_level.ChipQuantity, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(presale_inventory_level.ColaQuantity, postsale_inventory_level.ColaQuantity);




        }

        [TestMethod]
        public void Buy_Cola_When_No_Product_Is_Available_And_Check_Returning_Change_And_Display_Message()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            string vendingMachineFollowUpMessageExpected;
            int vendingMacineValue;

            Inventory presale_inventory_level;
            Inventory postsale_inventory_level;

            Inventory i = new Inventory();
            i.CandyQuantity = 3;
            i.ChipQuantity = 3;
            i.ColaQuantity = 0;
            dependentClass.SetInventoryLevels(i);


            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            presale_inventory_level = dependentClass.GetInventoryLevels();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            vendingMachineFollowUpMessageExpected = string.Format("{0:C}", System.Convert.ToDecimal(vendingMacineValue) / 100m);

            postsale_inventory_level = dependentClass.GetInventoryLevels();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);
            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual("SOLD OUT", vendingMachineMessage);
            Assert.AreEqual(150, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineFollowUpMessage);

            Assert.AreEqual(presale_inventory_level.CandyQuantity, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(presale_inventory_level.ChipQuantity, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(presale_inventory_level.ColaQuantity, postsale_inventory_level.ColaQuantity);



        }

        [TestMethod]
        public void Buy_Cola_When_No_Product_Is_Available_No_Money_Added_And_Check_Returning_Change_And_Display_Message()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            Inventory presale_inventory_level;
            Inventory postsale_inventory_level;

            Inventory i = new Inventory();
            i.CandyQuantity = 3;
            i.ChipQuantity = 3;
            i.ColaQuantity = 0;
            dependentClass.SetInventoryLevels(i);


            presale_inventory_level = dependentClass.GetInventoryLevels();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInPennies();

            postsale_inventory_level = dependentClass.GetInventoryLevels();


            Assert.AreEqual(false, productDispensed);
            Assert.AreEqual("SOLD OUT", vendingMachineMessage);
            Assert.AreEqual(0, vendingMacineValue);
            Assert.AreEqual("INSERT COIN", vendingMachineFollowUpMessage);

            Assert.AreEqual(presale_inventory_level.CandyQuantity, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(presale_inventory_level.ChipQuantity, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(presale_inventory_level.ColaQuantity, postsale_inventory_level.ColaQuantity);



        }

    }
}
