using Tyuiu.Kucherenkonm.Sprint3.Task2.V24.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:                  Оператор цикла do-while                          *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*  Написать программу на C#, используя цикл do-while, которая вычисляет   *");
        Console.WriteLine("*                    произведение ряда по формуле                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double value = 0.25;
        int startValue = 1;
        int stopValue = 8;
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));
        Console.ReadKey();

    }
}