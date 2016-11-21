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
            
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(new Inventory());
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            Inventory i = dependentClass.GetInventoryLevels();

            Assert.AreEqual(100, i.CandyQuantity);
            Assert.AreEqual(100, i.ChipQuantity);
            Assert.AreEqual(100, i.ColaQuantity);

        }

        [TestMethod]
        public void CheckChangingInventoryLevelsInTheVendingMachine()
        {

            MockVendingMachineDependency dependency = new MockVendingMachineDependency(new Inventory(1,1,1));
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            Inventory i = dependentClass.GetInventoryLevels();

            Assert.AreEqual(1, i.CandyQuantity);
            Assert.AreEqual(1, i.ChipQuantity);
            Assert.AreEqual(1, i.ColaQuantity);

        }

        [TestMethod]
        public void Buy_Cola_And_Check_Inventory_Level_Going_Down_By_One()
        {
            Inventory presale_inventory_level = new Inventory(10, 10, 10);
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(presale_inventory_level);
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            int PresaleColaInventory, PresaleCandyInventory, PresaleChipInventory;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;
            Inventory postsale_inventory_level;


            PresaleCandyInventory = presale_inventory_level.CandyQuantity;
            PresaleChipInventory = presale_inventory_level.ChipQuantity;
            PresaleColaInventory = presale_inventory_level.ColaQuantity;


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

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

            Assert.AreEqual(PresaleCandyInventory, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(PresaleChipInventory, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(PresaleColaInventory - 1, postsale_inventory_level.ColaQuantity);
        }

        [TestMethod]
        public void Buy_Bag_Of_Chips_And_Check_Inventory_Level_Going_Down_By_One()
        {
            Inventory presale_inventory_level = new Inventory(10, 10, 10);
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(presale_inventory_level);
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            int PresaleColaInventory, PresaleCandyInventory, PresaleChipInventory;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;
            Inventory postsale_inventory_level;


            PresaleCandyInventory = presale_inventory_level.CandyQuantity;
            PresaleChipInventory = presale_inventory_level.ChipQuantity;
            PresaleColaInventory = presale_inventory_level.ColaQuantity;


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

            Assert.AreEqual(PresaleCandyInventory, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(PresaleChipInventory - 1, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(PresaleColaInventory, postsale_inventory_level.ColaQuantity);

        }

        [TestMethod]
        public void Buy_Candy_And_Check_Inventory_Level_Going_Down_By_One()
        {

            Inventory presale_inventory_level = new Inventory(10, 10, 10);
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(presale_inventory_level);
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            int PresaleColaInventory, PresaleCandyInventory, PresaleChipInventory;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;
            Inventory postsale_inventory_level;


            PresaleCandyInventory = presale_inventory_level.CandyQuantity;
            PresaleChipInventory = presale_inventory_level.ChipQuantity;
            PresaleColaInventory = presale_inventory_level.ColaQuantity;

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
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

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

            Assert.AreEqual(PresaleCandyInventory - 1, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(PresaleChipInventory, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(PresaleColaInventory, postsale_inventory_level.ColaQuantity);
        }

        [TestMethod]
        public void Buy_Cola_When_No_Product_Is_Available_And_Check_Returning_Change_And_Display_Message()
        {

            Inventory presale_inventory_level = new Inventory(3, 3, 0);
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(presale_inventory_level);
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            int PresaleColaInventory, PresaleCandyInventory, PresaleChipInventory;
            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            string vendingMachineFollowUpMessageExpected;
            int vendingMacineValue;
            Inventory postsale_inventory_level;

            PresaleCandyInventory = presale_inventory_level.CandyQuantity;
            PresaleChipInventory = presale_inventory_level.ChipQuantity;
            PresaleColaInventory = presale_inventory_level.ColaQuantity;


            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

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
            Assert.AreEqual(vendingMachineFollowUpMessageExpected, vendingMachineFollowUpMessage);

            Assert.AreEqual(PresaleCandyInventory, postsale_inventory_level.CandyQuantity);
            Assert.AreEqual(PresaleChipInventory, postsale_inventory_level.ChipQuantity);
            Assert.AreEqual(PresaleColaInventory, postsale_inventory_level.ColaQuantity);



        }

        [TestMethod]
        public void Buy_Cola_When_No_Product_Is_Available_No_Money_Added_And_Check_Returning_Change_And_Display_Message()
        {

            Inventory presale_inventory_level = new Inventory(3, 3, 0);
            MockVendingMachineDependency dependency = new MockVendingMachineDependency(presale_inventory_level);
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool productDispensed;
            string vendingMachineMessage;
            string vendingMachineFollowUpMessage;
            int vendingMacineValue;

            Inventory postsale_inventory_level;

            productDispensed = dependentClass.Dispense(Products.Cola);
            vendingMachineMessage = dependentClass.GetVendingMachineDisplay();
            vendingMachineFollowUpMessage = dependentClass.GetVendingMachineDisplay();
            vendingMacineValue = dependentClass.GetVendingMachineCoinValueInCents();

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
