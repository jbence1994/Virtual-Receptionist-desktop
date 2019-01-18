﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace virtual_receptionist.Model.Tests
{
    [TestClass()]
    public class DataRepositoryBillingTests
    {
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 8.700 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_DevelopFunction()
        {
            DataRepository dataStore = new DataRepository();
            double expected = 7830;
            double actual = dataStore.CountDiscountPrice(8700, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 11.400 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_Test1()
        {
            DataRepository dataStore = new DataRepository();
            double expected = 10260;
            double actual = dataStore.CountDiscountPrice(11400, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 11.400 Ft 10%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_Test2()
        {
            DataRepository dataStore = new DataRepository();
            double expected = 12690;
            double actual = dataStore.CountDiscountPrice(14100, 10);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
        /// <summary>
        /// Tesztmetódus, amely kiszámolja 8700 Ft 20%-át
        /// </summary>
        [TestMethod()]
        public void CountItemPriceWithDiscountTest_Test3()
        {
            DataRepository dataStore = new DataRepository();
            double expected = 6960;
            double actual = dataStore.CountDiscountPrice(8700, 20);
            Assert.AreEqual(expected, actual, "Bukik a teszt jó végeredményre!");
        }
    }
}