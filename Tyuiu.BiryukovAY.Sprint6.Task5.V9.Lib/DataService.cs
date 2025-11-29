using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public double[] LoadFromDataFile(string path)
        {
            List<double> zeroElements = new List<double>();

            try
            {
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    if (double.TryParse(line.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                    {
                        double roundedNumber = Math.Round(number, 3);

                        if (Math.Abs(roundedNumber) < 0.0001)
                        {
                            zeroElements.Add(roundedNumber);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}");
            }

            return zeroElements.ToArray();
        }
    }
}
