using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint3.Task3.V14.Lib;

namespace Tyuiu.ShahabAJ2.Sprint3.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 14;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.592; // Ожидаемое значение (примерное)

            Assert.AreEqual(wait, result, 0.001);
        }

        [TestMethod]
        public void ValidGetSumSeriesSmallRange()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 3;

            double result = ds.GetSumSeries(value, startValue, stopValue);
            // Расчет для k=1-3
            double wait = 1.067; // Примерное значение

            Assert.AreEqual(wait, result, 0.001);
        }
    }
}