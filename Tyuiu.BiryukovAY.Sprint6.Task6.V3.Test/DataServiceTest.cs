using System;
using Tyuiu.BiryukovAY.Sprint6.Task6.V3.Lib;
namespace Tyuiu.BiryukovAY.Sprint6.Task6.V3.Test
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
                "Hello world from Russia",
                "Programming is great",
                "This text contains words with r",
                "Apple banana cherry",
                "Red green blue"
            });

            string result = ds.CollectTextFromFile(testFilePath);
            string expected = "world from Russia Programming great contains words with r cherry Red green";

            Assert.AreEqual(expected, result);

            File.Delete(testFilePath);
        }

        [TestMethod]
        public void NoWordsWithR()
        {
            DataService ds = new DataService();

            string testFilePath = "test_file2.txt";
            File.WriteAllLines(testFilePath, new string[]
            {
                "Hello world",
                "Apple banana",
                "Test text"
            });

            string result = ds.CollectTextFromFile(testFilePath);

            Assert.AreEqual("", result);

            File.Delete(testFilePath);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InvalidFileCollectTextFromFile()
        {
            DataService ds = new DataService();
            ds.CollectTextFromFile("nonexistent_file.txt");
        }
    }
}