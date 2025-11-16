using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task7.V6.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] wait = { 25.81, 17.65, 8.16, 3.25, 0.57, 0, -1.48, -3.43, -7.11, -11.93, -17.42 };
            double[] result = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}