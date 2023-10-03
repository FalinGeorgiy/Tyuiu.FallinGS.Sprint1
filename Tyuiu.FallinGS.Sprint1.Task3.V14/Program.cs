using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task3.V14.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task3.V14
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
            Console.WriteLine("* Задание №3                                                              #");
            Console.WriteLine("* Вариант №14                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, #");
            Console.WriteLine("*  выполняет указанные расчёты и печатает результат на экране.            #");
            Console.WriteLine("*                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные: Вводит пользователь                                    #");
            Console.WriteLine("###########################################################################");


            double x;

            Console.WriteLine("Введите number:");
            x = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("ReversNumber = " + ds.ReverseNumber(x));

            Console.ReadLine();
        }
    }
}
