using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            int rows = 10;
            int cols = 10;
            int[,] matrix = new int[rows, cols];

            try
            {
                string[] lines = File.ReadAllLines(path);

                for (int i = 0; i < rows && i < lines.Length; i++)
                {
                    string line = lines[i].Trim();
                    if (string.IsNullOrEmpty(line)) continue;

                    string[] parts = line.Split(',');

                    for (int j = 0; j < cols && j < parts.Length; j++)
                    {
                        if (int.TryParse(parts[j].Trim(), out int value))
                        {
                            matrix[i, j] = value;
                        }
                    }
                }

                return matrix;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка чтения файла: {ex.Message}");
            }
        }

        public int[,] ProcessMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = (int[,])matrix.Clone();

            for (int j = 0; j < cols; j++)
            {
                if (result[1, j] % 2 == 0)
                {
                    result[1, j] = 1;
                }
            }

            return result;
        }
    }
}
