using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint2.Task7.V3.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.2;
            double y = 0.5;

            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}