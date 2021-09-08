using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начинаем");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Пишем красным цветом.");
            Console.ResetColor();
            Console.WriteLine("Сбросили цвет");


            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Очистили экран");

            Console.ReadKey();
        }
    }
}
