using System;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BiryukovAY.Sprint6.Task0.V30.Lib
{
    public class DataService : ISprint6Task0V30
    {
        public double Calculate(int x)
        {
            double result = x * Math.Sqrt(x + 3);

            return Math.Round(result, 3);
        }
    }
}
