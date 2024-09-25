using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Tyuiu.NajibN.Sprint0.Task2.V0.Lib;
namespace Tyuiu.NajibN.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Вызов Класса DataService и Метода GetMessage
            //из библиотека Tyuiu.NajibN.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Нассер"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
