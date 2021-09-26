using System;
using System.Diagnostics;
using System.Threading;

namespace DebugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch SW = new Stopwatch(); // Создаем объект
            SW.Start(); // Запускаем
            Thread.Sleep(1500); // Наш код
            SW.Stop(); //Останавливаем
            Console.WriteLine(Convert.ToString(SW.ElapsedMilliseconds)); // Время выполнения в миллисекундах
            Console.WriteLine(Convert.ToString(SW.Elapsed.Seconds)); // Время в секундах
            Console.WriteLine(Convert.ToString(SW.ElapsedTicks)); // Время в тиках


            Console.WriteLine("____________________________________");

            var startTime = Stopwatch.StartNew();

            //Код время исполнения которого хотим узнать
            Thread.Sleep(1500); // Наш код

            startTime.Stop();
            var resultTime = startTime.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", resultTime.Hours, resultTime.Minutes, resultTime.Seconds, resultTime.Milliseconds);
            Console.WriteLine(elapsedTime);

            Console.ReadKey();
        }
    }
}
