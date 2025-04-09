using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint2.Task3.V25.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task3.V25.Test
{
    [TestClass]
    public class DataSereviceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 3;
            double res = ds.Calculate(x);
            double wait = 8.956;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.333;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -36;
            double res = ds.Calculate(x);
            double wait = -9;
            Assert.AreEqual(wait, res);
        }
    }
}