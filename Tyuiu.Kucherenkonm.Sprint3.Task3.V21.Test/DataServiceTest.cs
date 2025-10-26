using Tyuiu.Kucherenkonm.Sprint3.Task3.V21.Lib;
namespace Tyuiu.Kucherenkonm.Sprint3.Task3.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string str = "f3g5ht g4j 34kg4";
            char chr = 'e';
            string res = ds.ReplaceNumOnChar(str,chr);
            string wait = "fegeht gej eekge";
            Assert.AreEqual(res, wait);
        }
    }
}
