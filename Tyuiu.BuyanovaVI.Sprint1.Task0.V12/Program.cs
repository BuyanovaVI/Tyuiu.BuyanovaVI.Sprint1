using Tyuiu.BuyanovaVI.Sprint1.Task0.V12.Lib;

// Задание
// Написать программу, которая вычисляет выражение (5 * 2 - 2) / 4 * 3



namespace Tyuiu.BuyanovaVI.Sprint1.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнилa: Буянова В. И. | СМАРТб-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнилa: Буянова В. И. | СМАРТб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (5 * 2 - 2) / 4 * 3     *");
            Console.WriteLine("* и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* (5 * 2 - 2) / 4 * 3                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            // Метод Calcelate находится в библиотеке Tyuiu.BuyanovaVI.Sprint1.Task0.V12.Lib
            // В классе DataService

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}

