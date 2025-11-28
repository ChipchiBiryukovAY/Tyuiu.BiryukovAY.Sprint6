using System;
using Tyuiu.BiryukovAY.Sprint6.Task1.V22.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task1.V22.Test
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
                12.09, 9.67, -1.5, 1.67, 0.5,
                2, 3.5, 5.33, 16.5, 11.83, 9.41
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
