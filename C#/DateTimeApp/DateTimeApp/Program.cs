using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //За месяц
            Console.WriteLine("За месяц ----------------------------------------");
            if (true)
            {
                DateTime date = Convert.ToDateTime("2019-12-01");
                int days = DateTime.DaysInMonth(2019, 12);

                List<DateTime> dtList = new List<DateTime>();
                for (int d = 0; d < days; d++)
                {
                    dtList.Add(date.AddDays(d));
                }

                foreach (DateTime dt in dtList)
                    Console.WriteLine(dt.ToString("yyyy-MM-dd"));
            }

            //За период
            Console.WriteLine("За период ----------------------------------------");
            if (true)
            {
                DateTime dtStart = Convert.ToDateTime("2019-12-25");
                DateTime dtEnd = Convert.ToDateTime("2020-01-05");
                DateTime date = dtStart;

                List<DateTime> dtList = new List<DateTime>();
                dtList.Add(dtStart);
                do
                {
                    date = date.AddDays(1);
                    dtList.Add(date);
                } while (dtEnd > date);

                foreach (DateTime dt in dtList)
                    Console.WriteLine(dt.ToString("yyyy-MM-dd"));
            }

            //Выполнение события с определенной даты
            Console.WriteLine("Событие с опредленной даты ----------------------------------------");
            if (true)
            {
                DateTime dt = Convert.ToDateTime("2021-09-01");

                if (dt <= DateTime.Now)
                {
                    Console.WriteLine("Событие выполнилось");
                }
                else
                {
                    Console.WriteLine("Дата начала еще не наступила.");
                }
            }

            //unixtimestamp
            Console.WriteLine("unixtimestamp ----------------------------------------");
            if (true)
            {
                //Текущее время по гринвичу в unixtimestamp
                Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                Console.WriteLine(unixTimestamp.ToString());

                //Текущее время в unixtimestamp
                Int32 unixTimestampMyTime = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                Console.WriteLine(unixTimestampMyTime.ToString());

                //Из unixtimestamp в DateTime
                System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(unixTimestampMyTime).ToLocalTime();
                Console.WriteLine(dtDateTime.ToString());
            }

            Console.WriteLine("День недели ----------------------------------------");
            if (true)
            {
                //DateTime dt = new DateTime(2003, 5, 1);
                DateTime dt = DateTime.Now;
                Console.WriteLine("Сегодня: {0:d} is {1}.", dt, dt.DayOfWeek);

                if (dt.DayOfWeek == DayOfWeek.Friday)
                    Console.WriteLine("Сегодня пятница!");
            }

            Console.ReadKey();
        }
    }
}
