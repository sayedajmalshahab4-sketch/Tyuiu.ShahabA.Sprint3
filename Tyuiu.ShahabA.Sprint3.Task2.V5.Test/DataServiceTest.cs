using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task2.V5.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double a = 0.75;
            double wait = 1.819;
            double result = ds.GetSumSeries(a);
            Assert.AreEqual(wait, result);
        }
    }
}