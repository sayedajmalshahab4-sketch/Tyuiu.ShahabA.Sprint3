using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task0.V16.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double x = 5;
            double wait = 15625.0;
            double result = ds.GetMultiplySeries(x);
            Assert.AreEqual(wait, result);
        }
    }
}