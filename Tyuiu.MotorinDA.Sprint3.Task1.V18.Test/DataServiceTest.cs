using Tyuiu.MotorinDA.Sprint3.Task1.V18.Lib;
namespace Tyuiu.MotorinDA.Sprint3.Task1.V18.Test
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
            Assert.AreEqual(0.109, res);
        }
    }
}
