using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task1.V23.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task1.V23
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
            Console.WriteLine("* Задание №1                                                              #");
            Console.WriteLine("* Вариант №23                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, #");
            Console.WriteLine("* вычисляет результат по формуле (x*Pi)/(2*a) и печатает его на экране.   #");
            Console.WriteLine("*                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные: (x*Pi)/(2*a)                                           #");
            Console.WriteLine("###########################################################################");


            double x, a;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение A:");
            a = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine(ds.Calculate(x, a));

            Console.ReadLine();




        }
    }
}
