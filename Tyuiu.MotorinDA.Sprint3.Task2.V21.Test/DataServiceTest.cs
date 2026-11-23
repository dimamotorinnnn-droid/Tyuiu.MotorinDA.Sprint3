using Tyuiu.MotorinDA.Sprint3.Task2.V21.Lib;
namespace Tyuiu.MotorinDA.Sprint3.Task2.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(0.092, res);
        }
    }
}
