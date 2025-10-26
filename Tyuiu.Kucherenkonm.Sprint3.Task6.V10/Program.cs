using Tyuiu.Kucherenkonm.Sprint3.Task6.V10.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Кучеренко Н. М. | ИИПб - 25 - 1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:              Обработка целочисленной информации                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Кучеренко Надежда Михайловна | ИИПб - 25 - 1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*   Напишите программу, которая ищет среди целых чисел, принадлежащих     *");
        Console.WriteLine("*        числовому отрезку [20, 32] сумму всех делителей больше 12        *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 20;
        int stopValue = 32;
        Console.WriteLine(" Старт ряда " + startValue);
        Console.WriteLine(" Конец ряда " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Сумма ряда = " + ds.GetSumTheDivisors(startValue,stopValue));

        Console.ReadKey();

    }
}