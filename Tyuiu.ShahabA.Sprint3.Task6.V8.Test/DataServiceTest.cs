using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task6.V8.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;
            int wait = 161;
            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, result);
        }
    }
}