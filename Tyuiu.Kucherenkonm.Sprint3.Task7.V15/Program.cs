using Tyuiu.Kucherenkonm.Sprint3.Task7.V15.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:       Добавление к решению итоговых проектов по спринту           *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*       Напишите программу, которая вывдит таблицу значений функции       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine(" Старт ряда " + startValue);
        Console.WriteLine(" Конец ряда " + stopValue);
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+--------------+--------------+");
        Console.WriteLine("|--------------|--------------|");
        Console.WriteLine("+--------------+--------------+");
        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,6:d}        |     {1,6:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+--------------+--------------+");

        Console.ReadKey();

    }
}