using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task2.V15.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task2.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Фалин Г.С | ИИПб-23-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Cпринт №1                                                               #");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        #");
            Console.WriteLine("* Задание №2                                                              #");
            Console.WriteLine("* Вариант №15                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, #");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            #");
            Console.WriteLine("* Известна длина стороны куба. Вычислить объём куба.                      #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные: Вводит пользователь                                    #");
            Console.WriteLine("###########################################################################");


            int x;

            Console.WriteLine("Введите значение cтороны куба:");
            x = Convert.ToInt32(Console.ReadLine());

           


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Обьем куба = " + ds.CalculateCubeVolume(x));

            Console.ReadLine();
        }
    }
}
