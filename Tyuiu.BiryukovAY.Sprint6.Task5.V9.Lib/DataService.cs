using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task5.V9.Lib
{
    public class DataService : ISprint6Task5V9
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double[] numbers = lines
                .Where(line => !string.IsNullOrWhiteSpace(line))
                .Select(line => double.Parse(line.Trim()))
                .ToArray();

            return numbers;
        }

        public double[] GetZeroElements(double[] array)
        {
            return array
                .Where(x => Math.Abs(x) < 0.0001)
                .Select(x => Math.Round(x, 3)) 
                .ToArray();
        }
    }
}
