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
                "-19,-4,13,-11,-15,5,-12,20,3,-19\n" +
                "-17,1,5,1,1,1,1,1,1,-5\n" +
                "11,-11,-10,16,18,13,-17,-13,1,4\n" +
                "2,-1,-17,16,4,-1,20,18,-5,-2\n" +
                "-17,-13,2,-12,4,-16,10,-16,2,-7\n" +
                "-6,4,-3,2,-4,2,-10,3,5,-19\n" +
                "11,7,20,-19,1,18,-3,-18,2,11\n" +
                "15,-14,-11,17,18,-18,2,18,19,1\n" +
                "-1,-12,-5,10,18,13,9,3,-8,16\n" +
                "9,-20,-12,9,15,-1,3,-11,6,-4");

            int[,] result = ds.GetMatrix(testFilePath);

            Assert.AreEqual(10, result.GetLength(0)); 
            Assert.AreEqual(10, result.GetLength(1)); 

            Assert.AreEqual(-19, result[0, 0]);
            Assert.AreEqual(-4, result[0, 1]);
            Assert.AreEqual(-5, result[1, 9]);
            Assert.AreEqual(-4, result[9, 9]);

            File.Delete(testFilePath);
        }

        [TestMethod]
        public void ValidProcessMatrix()
        {
            DataService ds = new DataService();

            int[,] inputMatrix = {
                {-19, -4, 13, -11, -15, 5, -12, 20, 3, -19},
                {-17, 1, 5, 1, 1, 1, 1, 1, 1, -5},
                {11, -11, -10, 16, 18, 13, -17, -13, 1, 4},
                {2, -1, -17, 16, 4, -1, 20, 18, -5, -2},
                {-17, -13, 2, -12, 4, -16, 10, -16, 2, -7},
                {-6, 4, -3, 2, -4, 2, -10, 3, 5, -19},
                {11, 7, 20, -19, 1, 18, -3, -18, 2, 11},
                {15, -14, -11, 17, 18, -18, 2, 18, 19, 1},
                {-1, -12, -5, 10, 18, 13, 9, 3, -8, 16},
                {9, -20, -12, 9, 15, -1, 3, -11, 6, -4}
            };

            int[,] result = ds.ProcessMatrix(inputMatrix);


            Assert.AreEqual(-17, result[1, 0]);
            Assert.AreEqual(1, result[1, 1]);
            Assert.AreEqual(5, result[1, 2]);
            Assert.AreEqual(1, result[1, 3]);
            Assert.AreEqual(1, result[1, 4]);
            Assert.AreEqual(1, result[1, 5]);
            Assert.AreEqual(1, result[1, 6]);
            Assert.AreEqual(1, result[1, 7]);
            Assert.AreEqual(1, result[1, 8]);
            Assert.AreEqual(-5, result[1, 9]);

            Assert.AreEqual(-19, result[0, 0]);
            Assert.AreEqual(11, result[2, 0]);
            Assert.AreEqual(9, result[9, 0]);
        }

        [TestMethod]
        public void ProcessMatrixWithEvenNumbers()
        {
            DataService ds = new DataService();

            int[,] inputMatrix = {
                {1, 2, 3},
                {4, 5, 6}, 
                {7, 8, 9}
            };

            int[,] result = ds.ProcessMatrix(inputMatrix);

            Assert.AreEqual(1, result[1, 0]); 
            Assert.AreEqual(5, result[1, 1]); 
            Assert.AreEqual(1, result[1, 2]); 
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
