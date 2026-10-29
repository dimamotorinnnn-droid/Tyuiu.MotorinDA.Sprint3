using Tyuiu.MotorinDA.Sprint3.Task0.V5.Lib;
namespace Tyuiu.MotorinDA.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 2;
            double res = ds.GetSumSeries(x, y);
            double wait = 1.412;
            Assert.AreEqual(wait, res);
        }
    }
}
