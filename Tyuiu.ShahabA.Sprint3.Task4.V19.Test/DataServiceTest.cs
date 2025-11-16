using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task4.V19.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double wait = 189.652;
            double result = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(wait, result);
        }
    }
}