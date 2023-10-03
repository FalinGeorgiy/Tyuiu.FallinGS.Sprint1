using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FallinGS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.FallinGS.Sprint1.Task6.V3
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
            Console.WriteLine("* Задание №6                                                              #");
            Console.WriteLine("* Вариант №3                                                             #");
            Console.WriteLine("* Выполнил: Фалин Георгий Сергеевич / ИИПб-23-1                           #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* УСЛОВИЕ:                                                                #");
            Console.WriteLine("* Написать программу: пользователь вводит текст.Напечатать строку,        #");
            Console.WriteLine("* составленную из последних литер всех слов.                              #");
            Console.WriteLine("*                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("* Исходные данные:                                                        #");
            Console.WriteLine("###########################################################################");


            string val;

            Console.WriteLine("Введите cтроку:");
            val = (Console.ReadLine());

          


            Console.WriteLine("###########################################################################");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Ответ = " +(ds.LastLetterWord(val)));

            Console.ReadLine();
        }
    }
}
