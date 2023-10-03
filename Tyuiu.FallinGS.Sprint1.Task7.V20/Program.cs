using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task7.V20.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task7.V20
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
            Console.WriteLine("* Задание №7                                                              #");
            Console.WriteLine("* Вариант №20                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       #");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      #");
            Console.WriteLine("*   Ответ округлите до 3 знаков после запятой.                            #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");


            double x;
            double y;

            

            Console.WriteLine("Введите x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Ответ = " + Math.Round(ds.Calculate(x,y), 3));

            Console.ReadLine();
        }
    }
}
