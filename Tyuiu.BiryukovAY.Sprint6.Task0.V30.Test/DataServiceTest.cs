using System;
using Tyuiu.BiryukovAY.Sprint6.Task0.V30.Lib;

namespace Tyuiu.BiryukovAY.Sprint6.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;

            double result = ds.Calculate(x);

            double expected = 3 * System.Math.Sqrt(6);
            expected = System.Math.Round(expected, 3);
            Assert.AreEqual(expected, result);
        }
    }
}
