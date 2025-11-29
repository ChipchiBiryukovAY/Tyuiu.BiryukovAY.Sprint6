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

            string testFilePath = "test_file.txt";
            File.WriteAllLines(testFilePath, new string[]
            {
                "1.2345",
                "0",
                "-2.567",
                "0.000",
                "3.14159",
                "0"
            });

            double[] result = ds.LoadFromDataFile(testFilePath);
            double[] expected = { 1.235, 0, -2.567, 0, 3.142, 0 };

            CollectionAssert.AreEqual(expected, result);

            File.Delete(testFilePath);
        }
    }
}
