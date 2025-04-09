using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint2.Task2.V14.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3, y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}