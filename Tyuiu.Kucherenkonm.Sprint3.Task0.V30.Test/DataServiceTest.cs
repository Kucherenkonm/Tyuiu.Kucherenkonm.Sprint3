using Tyuiu.Kucherenkonm.Sprint3.Task0.V30.Lib;
namespace Tyuiu.Kucherenkonm.Sprint3.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int endValue = 20;
            double res = ds.GetMultiplySeries(startValue, endValue);
            double wait = 2477.158;
            Assert.AreEqual(res, wait);
        }
    }
}