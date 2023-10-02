using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhramovNA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.KhramovNA.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил: Храмов Н. А. | АСОиУБ-23-3";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу в которой пользователь вводит текст, и программа     *");
            Console.WriteLine("* должна проверить есть ли в строке восклицательный ( ! ), и              *");
            Console.WriteLine("* вопросительные ( ? ) знаки.                                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();

            bool containsSpecSymbols = false;
            if (containsSpecSymbols)
            {
                Console.WriteLine("Строка содержит и восклицание, и вопрос");
            }
            else
            {
                Console.WriteLine("Строка не содержит и восклицание, и вопроса");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckSpecSymbols(text));

            Console.ReadKey();
        }
    }
}