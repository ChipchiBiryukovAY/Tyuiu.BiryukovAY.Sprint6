using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] resultMatrix = (int[,])matrix.Clone();

            int secondRow = 1;

            for (int j = 0; j < cols; j++)
            {
                if (resultMatrix[secondRow, j] % 2 == 0)
                {
                    resultMatrix[secondRow, j] = 0;
                }
            }

            return resultMatrix;
        }
    }
}
