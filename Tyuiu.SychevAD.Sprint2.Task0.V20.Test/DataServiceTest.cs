using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint2.Task0.V20.Lib;

namespace Tyuiu.SychevAD.Sprint2.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations1075_275()
        {
            DataService ds = new DataService();

            int x = 1075;
            int y = 275;
            bool[] result = ds.GetCompareOperations(x, y);

            bool[] wait = { true, false, true, false, true, false };

            CollectionAssert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidVariousValues()
        {
            DataService ds = new DataService();

            // Тестируем на различных значениях
            TestCase(ds, 1075, 275);    // оригинальные значения
            TestCase(ds, 500, 300);     // другие значения
            TestCase(ds, 1000, 500);    // большая разница
            TestCase(ds, 50, 10);       // маленькие значения
            TestCase(ds, -100, -200);   // отрицательные
        }

        private void TestCase(DataService ds, int x, int y)
        {
            bool[] result = ds.GetCompareOperations(x, y);

            // Проверяем ожидаемую последовательность
            Assert.AreEqual(true, result[0], $"x={x}, y={y}: result[0]");
            Assert.AreEqual(false, result[1], $"x={x}, y={y}: result[1]");
            Assert.AreEqual(true, result[2], $"x={x}, y={y}: result[2]");
            Assert.AreEqual(false, result[3], $"x={x}, y={y}: result[3]");
            Assert.AreEqual(true, result[4], $"x={x}, y={y}: result[4]");
            Assert.AreEqual(false, result[5], $"x={x}, y={y}: result[5]");
        }

        [TestMethod]
        public void ValidEdgeCases()
        {
            DataService ds = new DataService();

            // Граничные случаи
            TestCase(ds, 0, 0);         // нули
            TestCase(ds, int.MaxValue, int.MaxValue - 1000); // большие числа
            TestCase(ds, -1000, -2000); // отрицательные с большой разницей
        }
    }
}