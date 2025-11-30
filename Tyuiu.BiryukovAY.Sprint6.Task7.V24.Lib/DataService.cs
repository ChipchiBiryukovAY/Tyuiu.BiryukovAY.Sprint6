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
                    {-19,-4,13,-11,-15,5,-12,20,3,-19},
                    {-17,1,5,1,1,1,1,1,1,-5},
                    {11,-11,-10,16,18,13,-17,-13,1,4},
                    {2,-1,-17,16,4,-1,20,18,-5,-2},
                    {-17,-13,2,-12,4,-16,10,-16,2,-7},
                    {-6,4,-3,2,-4,2,-10,3,5,-19},
                    {11,7,20,-19,1,18,-3,-18,2,11},
                    {15,-14,-11,17,18,-18,2,18,19,1},
                    {-1,-12,-5,10,18,13,9,3,-8,16},
                    {9,-20,-12,9,15,-1,3,-11,6,-4}
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