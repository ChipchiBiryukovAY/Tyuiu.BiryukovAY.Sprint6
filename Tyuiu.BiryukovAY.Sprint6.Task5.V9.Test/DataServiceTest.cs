using System;
using Tyuiu.BiryukovAY.Sprint6.Task5.V9.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            File.WriteAllText(testFilePath, "1.5\n0\n-2.3\n0.0\n4.7\n-0.000\n8.9\n");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (File.Exists(testFilePath))
                File.Delete(testFilePath);
        }

        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testFilePath);

            double[] expected = { 1.5, 0, -2.3, 0.0, 4.7, -0.000, 8.9 };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidGetZeroElements()
        {
            DataService ds = new DataService();
            double[] data = { 1.5, 0, -2.3, 0.0, 4.7, -0.000, 8.9 };
            double[] zeroElements = ds.GetZeroElements(data);

            double[] expected = { 0, 0, 0 }; 
            CollectionAssert.AreEqual(expected, zeroElements);
        }

        [TestMethod]
        public void NoZeroElements()
        {
            DataService ds = new DataService();
            double[] data = { 1.5, 2.3, 4.7, 8.9 };
            double[] zeroElements = ds.GetZeroElements(data);

            Assert.AreEqual(0, zeroElements.Length);
        }
    }
}
