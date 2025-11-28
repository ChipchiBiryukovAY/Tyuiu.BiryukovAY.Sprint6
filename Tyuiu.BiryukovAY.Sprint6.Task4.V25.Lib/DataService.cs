using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task4.V25.Lib
{
    public class DataService : ISprint6Task4V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double result = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;
                resultArray[count] = Math.Round(result, 2);
                count++;
            }
            return resultArray;
        }
    }
}
