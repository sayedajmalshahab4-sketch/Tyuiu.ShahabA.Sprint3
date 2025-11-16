using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint3.Task3.V16.Lib;

namespace Tyuiu.ShahabA.Sprint3.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "Ice nice Ice creamcc";
            char ch = 'c';
            int wait = 5;
            int result = ds.GetCharCount(str, ch);
            Assert.AreEqual(wait, result);
        }
    }
}