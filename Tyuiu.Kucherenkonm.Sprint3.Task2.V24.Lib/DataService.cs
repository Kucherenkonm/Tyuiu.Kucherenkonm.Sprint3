using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.Kucherenkonm.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            value = 0.25;
            do
            {
                multiplySeries = multiplySeries * (Math.Pow(value, startValue) + 4) * Math.Cos(startValue);
                startValue++;
            }
            while(startValue<=stopValue);
            return Math.Round(multiplySeries, 3);
        }
    }
}
