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
            DataService ds = new DataService();

            string testFilePath = "TestInputFile.txt";
            string[] testData = {
                "-13.0", "-19.0", "-9.82", "13.0", "11.49",
                "-9.71", "3.36", "0.0", "14.52", "16.0",
                "13.66", "0.0", "4.13", "-0.11", "19.0",
                "-17.36", "11.0", "11.28", "-12.0", "-12.35"
            };

            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testFilePath);

            double[] expected = { 0.0, 0.0 };

            CollectionAssert.AreEqual(expected, result);

            File.Delete(testFilePath);
        }
        [TestMethod]
        public void NoZeroElements()
        {
            string testFilePath = "TestInputFile2.txt";
            string[] testData = { "1.0", "2.0", "3.0", "4.0", "5.0" };

            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(testFilePath);

            Assert.AreEqual(0, result.Length);

            File.Delete(testFilePath);
        }

        [TestMethod]
        public void FileNotFound()
        {
            DataService ds = new DataService();

            Assert.ThrowsException<Exception>(() => ds.LoadFromDataFile("NonexistentFile.txt"));
        }
    }
}
