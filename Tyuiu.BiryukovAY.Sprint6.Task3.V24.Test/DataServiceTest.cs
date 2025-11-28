using System;
using Tyuiu.BiryukovAY.Sprint6.Task3.V24.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task3.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] inputMatrix = {
                {-17, -6, 10, 5, 3},
                {-10, -14, 10, -7, -3},
                {-19, 9, 8, -17, -9},
                {-19, -5, -9, -18, 14},
                {17, 12, 11, 12, 2}
            };

            int[,] result = ds.Calculate(inputMatrix);

            Assert.AreEqual(0, result[1, 0]); 
            Assert.AreEqual(0, result[1, 1]);  
            Assert.AreEqual(0, result[1, 2]); 
            Assert.AreEqual(-7, result[1, 3]); 
            Assert.AreEqual(-3, result[1, 4]);

            Assert.AreEqual(-17, result[0, 0]);
            Assert.AreEqual(-19, result[2, 0]);
            Assert.AreEqual(-19, result[3, 0]);
            Assert.AreEqual(17, result[4, 0]);
        }

        [TestMethod]
        public void NoEvenValuesInSecondRow()
        {
            DataService ds = new DataService();

            int[,] inputMatrix = {
                {1, 2, 3, 4, 5},
                {1, 3, 5, 7, 9}, 
                {2, 4, 6, 8, 10},
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 5}
            };

            int[,] result = ds.Calculate(inputMatrix);

            Assert.AreEqual(1, result[1, 0]);
            Assert.AreEqual(3, result[1, 1]);
            Assert.AreEqual(5, result[1, 2]);
            Assert.AreEqual(7, result[1, 3]);
            Assert.AreEqual(9, result[1, 4]);
        }
    }
}