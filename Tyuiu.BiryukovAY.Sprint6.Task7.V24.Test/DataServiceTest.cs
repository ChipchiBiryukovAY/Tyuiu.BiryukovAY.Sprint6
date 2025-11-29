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

            string testFilePath = "/app/data/AssesmentData/C#/Sprint6Task7/InPutDataFileTask7V24.csv";

            try
            {
                if (!File.Exists(testFilePath))
                {
                    Assert.Fail($"Файл не существует: {testFilePath}");
                }

                string fileContent = File.ReadAllText(testFilePath);
                string[] lines = fileContent.Split('\n');

                System.Diagnostics.Debug.WriteLine($"Количество строк в файле: {lines.Length}");
                for (int i = 0; i < Math.Min(lines.Length, 3); i++)
                {
                    System.Diagnostics.Debug.WriteLine($"Строка {i}: '{lines[i]}'");
                }

                int[,] result = ds.GetMatrix(testFilePath);

                System.Diagnostics.Debug.WriteLine($"Размер матрицы: {result.GetLength(0)}x{result.GetLength(1)}");

                Assert.AreEqual(10, result.GetLength(0), "Неверное количество строк");
                Assert.AreEqual(10, result.GetLength(1), "Неверное количество столбцов");


                Assert.AreEqual(-19, result[0, 0]);
                Assert.AreEqual(-4, result[0, 1]);
                Assert.AreEqual(-5, result[1, 9]);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }

        [TestMethod]
        public void CreateTestFileAndCheck()
        {
            string testFilePath = "test_matrix_10x10.csv";
            string[] testData = {
                "-19,-4,13,-11,-15,5,-12,20,3,-19",
                "-17,1,5,1,1,1,1,1,1,-5",
                "11,-11,-10,16,18,13,-17,-13,1,4",
                "2,-1,-17,16,4,-1,20,18,-5,-2",
                "-17,-13,2,-12,4,-16,10,-16,2,-7",
                "-6,4,-3,2,-4,2,-10,3,5,-19",
                "11,7,20,-19,1,18,-3,-18,2,11",
                "15,-14,-11,17,18,-18,2,18,19,1",
                "-1,-12,-5,10,18,13,9,3,-8,16",
                "9,-20,-12,9,15,-1,3,-11,6,-4"
            };

            File.WriteAllLines(testFilePath, testData);

            DataService ds = new DataService();
            int[,] result = ds.GetMatrix(testFilePath);

            Assert.AreEqual(10, result.GetLength(0));
            Assert.AreEqual(10, result.GetLength(1));
            Assert.AreEqual(-19, result[0, 0]);
            Assert.AreEqual(-4, result[9, 9]);

            File.Delete(testFilePath);
        }
    }
}
