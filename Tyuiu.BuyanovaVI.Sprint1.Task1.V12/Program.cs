using Tyuiu.BuyanovaVI.Sprint1.Task1.V12.Lib;
//Задание
//Написать программу, кторая запрашивает у пользователя входные данные,
//вычисляет результат по формуле (х + у) / 6 и печатает его на экране

namespace Tyuiu.BuyanovaVI.Sprint1.Task1.V12
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
            Console.WriteLine("* Тема: Организация ввода/вывода в консоьных приложениях                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнилa: Буянова В. И. | СМАРТб-24-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
            Console.WriteLine("* вычисляет результат по фориуле (х + у) / 6 и печатает его на экран.     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            double x, y;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            //Метод Calculate находится в библиотеке Tyuiu.SpirinIS.Sprint1.Task0.V0.Lib
            //в классе DataService
            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();



        }
    }
}
