using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library1;

namespace CurNumberUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string number = "A123AB";
            bool expected = true;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string number = "A123ABC";
            bool expected = false;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string number = "A1234B";
            bool expected = false;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string number = "A123GB";
            bool expected = false;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string number = "AA23AB";
            bool expected = false;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            string number = "K474CM";
            bool expected = true;

            CarNumberCheck CNC = new CarNumberCheck();
            bool actual = CNC.CarNumber(number);

            Assert.AreEqual(expected, actual);
        }
    }
}
