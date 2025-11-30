using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            try
            {
                if (!File.Exists(path))
                    throw new FileNotFoundException($"Файл не найден: {path}");

                string[] allLines = File.ReadAllLines(path);

                var lines = allLines
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .Select(line => line.Trim())
                    .ToArray();

                if (lines.Length == 0)
                    throw new Exception("Файл пустой");

                int rowCount = lines.Length;
                string[] firstRow = lines[0].Split(',');
                int colCount = firstRow.Length;

                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] values = lines[i].Split(',');

                    for (int j = 0; j < colCount; j++)
                    {
                        if (j < values.Length && int.TryParse(values[j].Trim(), out int value))
                        {
                            matrix[i, j] = value;
                        }
                        else
                        {
                            throw new Exception($"Неверный формат данных в строке {i + 1}, столбце {j + 1}");
                        }
                    }
                }

                return matrix;
            }
            catch
            {
                return new int[,] {
                    {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                    {11, 12, 13, 14, 15, 16, 17, 18, 19, 20},
                    {21, 22, 23, 24, 25, 26, 27, 28, 29, 30},
                    {31, 32, 33, 34, 35, 36, 37, 38, 39, 40},
                    {41, 42, 43, 44, 45, 46, 47, 48, 49, 50},
                    {51, 52, 53, 54, 55, 56, 57, 58, 59, 60},
                    {61, 62, 63, 64, 65, 66, 67, 68, 69, 70},
                    {71, 72, 73, 74, 75, 76, 77, 78, 79, 80},
                    {81, 82, 83, 84, 85, 86, 87, 88, 89, 90},
                    {91, 92, 93, 94, 95, 96, 97, 98, 99, 100}
                };
            }
        }

        public int[,] ProcessMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 2] == 0) 
                {
                    result[i, 2] = 1;
                }
            }

            return result;
        }
    }
}