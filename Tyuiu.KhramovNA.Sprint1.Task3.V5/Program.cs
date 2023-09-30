using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhramovNA.Sprint1.Task3.V5.Lib;

namespace Tyuiu.KhramovNA.Sprint1.Task3.V5
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Храмов Н.А. | АСОиУБ 23-3                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            double mapScale;
            Console.WriteLine("Масштаб карты (количество км. в одном см.) -> ");
            mapScale = Convert.ToDouble(Console.ReadLine());
            double distanceBetweenPoints;
            Console.WriteLine("Расстояние между точками, изображающими населенные пункты (см) -> ");
            distanceBetweenPoints = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Расстояние между населенными пунктами " + Math.Round(ds.DistanceLength(mapScale, distanceBetweenPoints), 3) + " км");
            Console.ReadKey();
        }
    }
}
