using System;
using Tyuiu.BiryukovAY.Sprint6.Task4.V25.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task4.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = {
                13.96, 9.35, 5.72, 3.07, 1.4,
                0.54, 0.46, 1.07, 2.28, 3.99, 6.04
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
