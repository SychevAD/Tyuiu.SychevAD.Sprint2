using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SychevAD.Sprint2.Task6.V12.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 23;
            int m = 1;
            int n = 1;

            string res = ds.FindDateOfPreviousDay(g, m, n);
            string w = "31.12.22";


            Assert.AreEqual(Convert.ToString(w), res);
        }
    }
}