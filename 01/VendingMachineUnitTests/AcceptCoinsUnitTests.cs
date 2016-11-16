﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachineUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void A_Coin_Does_Not_Have_A_Nickel_Value_Throws_Invalid_Operation_Exception()
        {
            var coinValue = Coin.GetValueForNickel();
            Assert.AreEqual(5, coinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void A_Coin_Does_Not_Have_A_Dime_Value_Throws_Invalid_Operation_Exception()
        {
            var coinValue = Coin.GetValueForDime();
            Assert.AreEqual(10, coinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void A_Coin_Does_Not_Have_A_Quarter_Value_Throws_Invalid_Operation_Exception()
        {
            var coinValue = Coin.GetValueForQuarter();
            Assert.AreEqual(25, coinValue);
        }






    }
}
