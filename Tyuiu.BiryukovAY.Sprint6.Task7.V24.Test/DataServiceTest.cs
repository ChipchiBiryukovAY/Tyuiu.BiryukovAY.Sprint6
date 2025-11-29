using System;
using Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string testFilePath = "test_matrix.csv";
            File.WriteAllText(testFilePath,
                "1,2,3,4,5\n" +
                "6,7,8,9,10\n" +
                "11,12,13,14,15\n" +
                "16,17,18,19,20\n" +
                "21,22,23,24,25");

            int[,] result = ds.GetMatrix(testFilePath);

            Assert.AreEqual(5, result.GetLength(0)); 
            Assert.AreEqual(5, result.GetLength(1)); 
            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(25, result[4, 4]);

            File.Delete(testFilePath);
        }

        [TestMethod]
        public void ValidProcessMatrix()
        {
            DataService ds = new DataService();

            int[,] inputMatrix = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25}
            };

            int[,] result = ds.ProcessMatrix(inputMatrix);

            Assert.AreEqual(1, result[1, 0]);
            Assert.AreEqual(7, result[1, 1]); 
            Assert.AreEqual(1, result[1, 2]); 
            Assert.AreEqual(9, result[1, 3]); 
            Assert.AreEqual(1, result[1, 4]); 

            Assert.AreEqual(1, result[0, 0]);
            Assert.AreEqual(11, result[2, 0]);
            Assert.AreEqual(16, result[3, 0]);
            Assert.AreEqual(21, result[4, 0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidFileGetMatrix()
        {
            DataService ds = new DataService();
            ds.GetMatrix("nonexistent_file.csv");
        }
    }
}
