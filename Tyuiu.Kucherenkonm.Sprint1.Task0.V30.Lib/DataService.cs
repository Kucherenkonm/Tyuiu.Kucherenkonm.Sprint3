using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kucherenkonm.Sprint1.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double series = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                series = series * i * (Math.Pow(Math.Sin(1), 10));
            }
            return Math.Round(series,3);
        }
    }
}
