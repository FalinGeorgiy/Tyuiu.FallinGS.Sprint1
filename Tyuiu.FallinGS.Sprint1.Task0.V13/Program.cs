using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task0.V13.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task0.V13
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
            Console.WriteLine("* Вариант №13                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 24/(6*2)-24/6/4         #");
            Console.WriteLine("* и печатает результат на экране.                                         #");
            Console.WriteLine("*                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные: 24/(6*2)-24/6/4                                        #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               #");
            Console.WriteLine("###########################################################################");



            Console.WriteLine(ds.Calculate());

            Console.ReadLine();



        }
    }
}