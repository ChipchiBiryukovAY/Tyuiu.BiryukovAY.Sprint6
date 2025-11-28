using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task1.V22.Lib
{
    public class DataService : ISprint6Task1V22
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] resultArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + 1;

                if (Math.Abs(denominator) < 0.0001)
                {
                    resultArray[count] = 0;
                }
                else
                {
                    double numerator = 2 * x - x; 
                    double fraction = numerator / denominator;
                    double result = 3 * x + 2 - fraction;
                    resultArray[count] = Math.Round(result, 2);
                }
                count++;
            }
            return resultArray;
        }
    }
}
