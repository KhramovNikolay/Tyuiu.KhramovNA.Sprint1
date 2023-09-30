using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhramovNA.Sprint1.Task2.V15.Lib;

namespace Tyuiu.KhramovNA.Sprint1.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнил Храмов Н. А. | АСОиУБ 23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Храмов Н.А. | АСОиУБ 23-3                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            int x;
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите длину стороны куба                                              *");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Объём куба = " + ds.CalculateCubeVolume(x));
            Console.ReadLine();

        }
    }
}
