using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;
using VendingMachineUnitTests.Mocks;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class ReturnCoinsUnitTests
    {
        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned1()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            Change c = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);

            Assert.AreEqual(1, c.Nickels);
            Assert.AreEqual(1, c.Dimes);
            Assert.AreEqual(1, c.Quarters);

        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned2()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change c = new Change();

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddNickelToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddNickelToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(5, c.Nickels);
            Assert.AreEqual(0, c.Dimes);
            Assert.AreEqual(0, c.Quarters);
        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned3()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change c = new Change();


            result1 = dependentClass.AddDimeToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(0, c.Nickels);
            Assert.AreEqual(5, c.Dimes);
            Assert.AreEqual(0, c.Quarters);

        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned4()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change c = new Change();


            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(0, c.Nickels);
            Assert.AreEqual(0, c.Dimes);
            Assert.AreEqual(5, c.Quarters);

        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned5()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change c = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(1, c.Nickels);
            Assert.AreEqual(2, c.Dimes);
            Assert.AreEqual(3, c.Quarters);
        }


        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned6()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change c = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddDimeToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(2, c.Nickels);
            Assert.AreEqual(4, c.Dimes);
            Assert.AreEqual(0, c.Quarters);
        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned7()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change c = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(2, c.Nickels);
            Assert.AreEqual(0, c.Dimes);
            Assert.AreEqual(4, c.Quarters);

        }

        [TestMethod]
        public void Keep_Track_Of_The_Coints_Entered_So_They_Can_Be_Returned8()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change c = new Change();


            result1 = dependentClass.AddDimeToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            c = dependentClass.GetChangeInVendingMachine();

            Assert.AreEqual(0, c.Nickels);
            Assert.AreEqual(4, c.Dimes);
            Assert.AreEqual(2, c.Quarters);

        }


        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return1()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);

            Assert.AreEqual(1, change_before_return.Nickels);
            Assert.AreEqual(1, change_before_return.Dimes);
            Assert.AreEqual(1, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return2()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change change_before_return = new Change();
            Change change_after_return = new Change();

            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddNickelToVendingMachine();
            result4 = dependentClass.AddNickelToVendingMachine();
            result5 = dependentClass.AddNickelToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(5, change_before_return.Nickels);
            Assert.AreEqual(0, change_before_return.Dimes);
            Assert.AreEqual(0, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return3()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddDimeToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(0, change_before_return.Nickels);
            Assert.AreEqual(5, change_before_return.Dimes);
            Assert.AreEqual(0, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return4()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddQuarterToVendingMachine();
            result2 = dependentClass.AddQuarterToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);

            Assert.AreEqual(0, change_before_return.Nickels);
            Assert.AreEqual(0, change_before_return.Dimes);
            Assert.AreEqual(5, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return5()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(1, change_before_return.Nickels);
            Assert.AreEqual(2, change_before_return.Dimes);
            Assert.AreEqual(3, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }


        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return6()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddDimeToVendingMachine();
            result6 = dependentClass.AddDimeToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(2, change_before_return.Nickels);
            Assert.AreEqual(4, change_before_return.Dimes);
            Assert.AreEqual(0, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return7()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddNickelToVendingMachine();
            result2 = dependentClass.AddNickelToVendingMachine();
            result3 = dependentClass.AddQuarterToVendingMachine();
            result4 = dependentClass.AddQuarterToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
            Assert.AreEqual(true, result6);

            Assert.AreEqual(2, change_before_return.Nickels);
            Assert.AreEqual(0, change_before_return.Dimes);
            Assert.AreEqual(4, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }

        [TestMethod]
        public void Put_Some_Coins_Into_The_Vending_Machine_And_Put_Them_Into_The_Coin_Return8()
        {
            MockVendingMachineDependency dependency = new MockVendingMachineDependency();
            VendingMachineDependentClass dependentClass = new VendingMachineDependentClass(dependency);

            bool result1, result2, result3, result4, result5, result6;
            Change change_before_return = new Change();
            Change change_after_return = new Change();


            result1 = dependentClass.AddDimeToVendingMachine();
            result2 = dependentClass.AddDimeToVendingMachine();
            result3 = dependentClass.AddDimeToVendingMachine();
            result4 = dependentClass.AddDimeToVendingMachine();
            result5 = dependentClass.AddQuarterToVendingMachine();
            result6 = dependentClass.AddQuarterToVendingMachine();

            change_before_return = dependentClass.GetChangeInVendingMachine();
            change_after_return = dependentClass.ReturnChangeInVendingMachine();

            Assert.AreEqual(0, change_before_return.Nickels);
            Assert.AreEqual(4, change_before_return.Dimes);
            Assert.AreEqual(2, change_before_return.Quarters);

            Assert.AreEqual(0, change_after_return.Nickels);
            Assert.AreEqual(0, change_after_return.Dimes);
            Assert.AreEqual(0, change_after_return.Quarters);

        }



    }
}
