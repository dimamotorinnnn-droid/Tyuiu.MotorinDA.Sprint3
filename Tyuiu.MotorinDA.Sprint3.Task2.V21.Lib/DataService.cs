using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MotorinDA.Sprint3.Task2.V21.Lib
{
    public class DataService : ISprint3Task2V21
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries += (1 / Math.Sin(startValue) + Math.Pow(2 * value, startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}
