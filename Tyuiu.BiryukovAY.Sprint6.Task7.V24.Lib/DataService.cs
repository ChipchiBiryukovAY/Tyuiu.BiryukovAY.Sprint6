using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path)
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .ToArray();

                if (lines.Length == 0)
                    return new int[0, 0];

                string[] firstLineValues = lines[0].Split(',');
                int rowCount = lines.Length;
                int colCount = firstLineValues.Length;

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
                            matrix[i, j] = 0; 
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

            int secondRow = 1;
            for (int j = 0; j < cols; j++)
            {
                if (result[secondRow, j] % 2 == 0)
                {
                    result[secondRow, j] = 1;
                }
            }

            return result;
        }
    }
}
