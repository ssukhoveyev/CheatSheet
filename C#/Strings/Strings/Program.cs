using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Количество вхождений подстроки в строку
            //Вариант 1
            string pattern = "Мир";
            string source = "Привет Мир! Привет Мир!";
            int count1 = new Regex(pattern).Matches(source).Count;
            Console.WriteLine("Количество вхождений построки: " + count1);

            //Вариант 2
            string s1 = "Привет Мир! Привет Мир!";
            string s2 = "Мир";
            int count2 = s1.Split(new string[] { s2 }, StringSplitOptions.None).Length - 1;
            Console.WriteLine("Количество вхождений построки: " + count2);

            //Оставить в строке только цифры
            Console.WriteLine(Regex.Replace("Строка2222", @"[^0-9$,]", ""));

            //Формат числа в строке
            decimal x = 100000.0700m;
            Console.WriteLine(x.ToString("N2"));

            Console.ReadKey();
        }
    }
}
