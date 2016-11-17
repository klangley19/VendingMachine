using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using VendingMachine;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class MakingChangeUnitTests
    {
        Change c;
        int expectedNickels;
        int expectedDimes;
        int expectedQuarters;

        [TestMethod]
        public void TestMakingChange1()
        {
            c = new Change();

            expectedNickels = 1;
            expectedDimes = 0;
            expectedQuarters = 0;

            c.MakeChange(0.05m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange2()
        {
            c = new Change();

            expectedNickels = 0;
            expectedDimes = 1;
            expectedQuarters = 0;

            c.MakeChange(0.10m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange3()
        {
            c = new Change();

            expectedNickels = 0;
            expectedDimes = 0;
            expectedQuarters = 1;

            c.MakeChange(0.25m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange4()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 0;

            c.MakeChange(0.15m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange5()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 2;
            expectedQuarters = 0;

            c.MakeChange(0.20m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange6()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 1;
            expectedQuarters = 1;

            c.MakeChange(0.35m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange7()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 1;
            expectedQuarters = 1;

            c.MakeChange(0.35m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange8()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 2;
            expectedQuarters = 1;

            c.MakeChange(0.45m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange9()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 0;
            expectedQuarters = 2;

            c.MakeChange(0.50m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange10()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 2;

            c.MakeChange(0.65m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange11()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 2;
            expectedQuarters = 2;

            c.MakeChange(0.70m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange12()
        {
            c = new Change();
            expectedNickels = 0;
            expectedDimes = 0;
            expectedQuarters = 3;

            c.MakeChange(0.75m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange13()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 3;

            c.MakeChange(0.90m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange14()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 4;

            c.MakeChange(1.15m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange15()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 10;

            c.MakeChange(2.65m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }

        [TestMethod]
        public void TestMakingChange16()
        {
            c = new Change();
            expectedNickels = 1;
            expectedDimes = 1;
            expectedQuarters = 19;

            c.MakeChange(4.90m);

            Assert.AreEqual(expectedNickels, c.Nickels);
            Assert.AreEqual(expectedDimes, c.Dimes);
            Assert.AreEqual(expectedQuarters, c.Quarters);

        }



    }
}

