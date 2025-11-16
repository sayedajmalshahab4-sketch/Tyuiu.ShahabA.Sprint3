using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task5.V9.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 14;
            double wait = 192.786;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Assert.AreEqual(wait, result);
        }
    }
}