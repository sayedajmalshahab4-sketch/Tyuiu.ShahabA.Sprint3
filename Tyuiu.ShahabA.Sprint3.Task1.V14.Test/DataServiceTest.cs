using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double t = 0.7;
            double wait = 7.226;
            double result = ds.GetSumSeries(t);
            Assert.AreEqual(wait, result);
        }
    }
}