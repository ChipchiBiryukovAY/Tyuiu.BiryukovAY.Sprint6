using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> numbers = new List<double>();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (double.TryParse(line.Trim(), out double number))
                    {
                        numbers.Add(Math.Round(number, 3));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}");
            }

            return numbers.ToArray();
        }
    }
}
