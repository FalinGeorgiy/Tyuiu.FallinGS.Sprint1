using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.FallinGS.Sprint1.Task3.V14.Lib
{
    public class DataService : ISprint1Task3V14
{
    public double ReverseNumber(double number)
    {
        string numberStr = number.ToString();
        char[] charArray = numberStr.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        double reversedNumber = double.Parse(reversedStr);
        return reversedNumber;

    }
}
}
