using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FilesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Путь к файлу приложения
            string fullPath = System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\MyProject.exe";
            Console.WriteLine("Путь к файлу приложения " + fullPath);

            //Сохраняем строку в файл
            StreamWriter streamWriter = File.CreateText("file1.txt");
            streamWriter.WriteLine("Строка в файле 1.");
            streamWriter.Close();

            //Вариант второй
            File.WriteAllText(@"file2.txt", "Строка в файле 2.");

            //Третий вариант
            using (StreamWriter sw = new StreamWriter(new FileStream(@"file.txt", FileMode.Append, FileAccess.Write)))
            {
                sw.WriteLine("Пишем строку в файл.");
                sw.Close();
            }

            //Информация о файле
            Console.WriteLine("Полный путь к файлу: " + new DirectoryInfo("file.txt").FullName);
            Console.WriteLine("Каталог в котором лежит файл: " + new DirectoryInfo("file.txt").Parent );
            Console.WriteLine("Расширение файла: " + new DirectoryInfo("file.txt").Extension);

            //Прочитать строку из файла
            Console.WriteLine("Строка из файла file.txt: " + File.ReadAllText(@"file.txt"));

            #region Контрольная сумма MD5
            using (FileStream fs = System.IO.File.OpenRead("file.txt"))
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fileData = new byte[fs.Length];
                fs.Read(fileData, 0, (int)fs.Length);
                byte[] checkSum = md5.ComputeHash(fileData);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                Console.WriteLine("Контрольная сумма MD5: " + result);
            }
            #endregion


            //Удаление файла
            File.Delete("file.txt");

            #region Список файлов
            string[] files = Directory.GetFiles(@"C:\", "*.*");
            Console.WriteLine("Всего файлов {0}.", files.Length);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            #endregion

            #region Список каталогов
            string[] dirs = Directory.GetDirectories(@"C:\", "*");
            Console.WriteLine("Всего каталогов: {0}", dirs.Length);

            foreach (string d in dirs)
                Console.WriteLine(d);
            #endregion

            Console.ReadKey();
        }
    }
}
