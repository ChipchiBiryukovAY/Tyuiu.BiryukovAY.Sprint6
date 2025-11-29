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
            File.WriteAllText(testFilePath,
                "rdRibhX swrfhvUjC NSRnNINXl raHsMtQF jiUFMDjMsEervIz QybRwHOetJ");

            string result = ds.CollectTextFromFile(testFilePath);
            string expected = "rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz";

            Assert.AreEqual(expected, result);

            File.Delete(testFilePath);
        }

        [TestMethod]
        public void DebugTest()
        {
            DataService ds = new DataService();

            string testData = "rdRibhX swrfhvUjC NSRnNINXl raHsMtQF jiUFMDjMsEervIz QybRwHOetJ";
            string testFilePath = "debug_test.txt";
            File.WriteAllText(testFilePath, testData);

            string result = ds.CollectTextFromFile(testFilePath);

            System.Diagnostics.Debug.WriteLine($"Результат: '{result}'");
            System.Diagnostics.Debug.WriteLine($"Ожидалось: 'rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz'");

            string[] resultWords = result.Split(' ');
            string[] expectedWords = "rdRibhX swrfhvUjC raHsMtQF jiUFMDjMsEervIz".Split(' ');

            CollectionAssert.AreEqual(expectedWords, resultWords);

            File.Delete(testFilePath);
        }
    }
}