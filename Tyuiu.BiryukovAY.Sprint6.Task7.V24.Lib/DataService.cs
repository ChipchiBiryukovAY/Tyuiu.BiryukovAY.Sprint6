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
                string[] allLines = File.ReadAllLines(path);

                List<string> validLines = new List<string>();
                foreach (string line in allLines)
                {
                    string trimmedLine = line.Trim();
                    if (!string.IsNullOrEmpty(trimmedLine))
                    {
                        validLines.Add(trimmedLine);
                    }
                }

                if (validLines.Count == 0)
                    return new int[0, 0];

                string[] firstLineValues = ParseCSVLine(validLines[0]);
                int rowCount = validLines.Count;
                int colCount = firstLineValues.Length;

                int[,] matrix = new int[rowCount, colCount];

                for (int i = 0; i < rowCount; i++)
                {
                    string[] values = ParseCSVLine(validLines[i]);

                    for (int j = 0; j < colCount; j++)
                    {
                        if (j < values.Length)
                        {
                            string cleanValue = values[j].Trim();
                            if (int.TryParse(cleanValue, NumberStyles.Integer, CultureInfo.InvariantCulture, out int value))
                            {
                                matrix[i, j] = value;
                            }
                            else
                            {
                                matrix[i, j] = 0;
                            }
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

        private string[] ParseCSVLine(string line)
        {
            return line.Split(',');
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
