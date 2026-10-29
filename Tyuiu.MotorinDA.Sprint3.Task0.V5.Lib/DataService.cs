using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MotorinDA.Sprint3.Task0.V5.Lib
{
    public class DataService : ISprint3Task0V5
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            for (int i = startValue; i < stopValue; i++)
            {
                sum += Math.Pow(1.0 / Math.Sin(i), 2);
            }
            return Math.Round(sum, 3);
        }
    }
}
