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

            #region Соединяем строки
            List<string> listString = new List<string>();
            listString.Add("String1");
            listString.Add("String2");
            listString.Add("String3");

            StringBuilder sb = new StringBuilder();
            foreach(string s in listString)
                sb.Append(s);
            Console.WriteLine(sb);

            Console.WriteLine(string.Join(",", listString));

            string phrase = listString.Aggregate((partialPhrase, word) => $"{partialPhrase},{word}");
            Console.WriteLine(phrase);

            #endregion

            #region Сравнение строк

            string emptyString = "";

            Console.WriteLine(emptyString != "");
            Console.WriteLine(emptyString.Length != 0);
            Console.WriteLine(String.IsNullOrEmpty(emptyString));


            string string1 = "Hello World";
            Console.WriteLine(string1.Equals("Hello World"));

            

            #endregion

            Console.ReadKey();
        }
    }
}
