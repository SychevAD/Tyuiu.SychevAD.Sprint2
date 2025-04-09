using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint2.Task4.V11.Lib;
namespace Tyuiu.SychevAD.Sprint2.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;//
            double y = 2;//
            double res = ds.Calculate(x, y);
            double wait = 25;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 40;//
            double y = -40;//
            double res = ds.Calculate(x, y);
            double wait = -60.893;
            Assert.AreEqual(wait, res);
        }
    }
}