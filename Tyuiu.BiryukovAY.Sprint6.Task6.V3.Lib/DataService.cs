using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string path)
        {
            List<string> wordsWithR = new List<string>();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
 
                    string[] words = line.Split(new char[] { ' ', '\t', ',', '.', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '"', '\'' },
                                              StringSplitOptions.RemoveEmptyEntries);

                    foreach (string word in words)
                    {

                        if (word.Contains('r'))
                        {
                            wordsWithR.Add(word);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}");
            }

            return string.Join(" ", wordsWithR);
        }
    }
}
