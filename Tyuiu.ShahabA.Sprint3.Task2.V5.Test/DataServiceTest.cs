using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint3.Task3.V5.Lib;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -1.623; // Ожидаемое значение

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}