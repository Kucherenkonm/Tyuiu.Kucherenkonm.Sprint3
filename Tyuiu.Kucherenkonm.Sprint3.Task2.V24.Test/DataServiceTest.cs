using Tyuiu.Kucherenkonm.Sprint3.Task2.V24.Lib;
namespace Tyuiu.Kucherenkonm.Sprint3.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 55217.446;
            Assert.AreEqual(res, wait);
        }
    }
}
