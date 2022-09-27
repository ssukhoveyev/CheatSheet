using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source.
            int[] scores = { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            // Output: 97 92 81

            //Сортировка
            IEnumerable<int> highScoresQuery =
            from score in scores
            where score > 80
            orderby score //descending
            select score;

            foreach (int i in highScoresQuery)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            IEnumerable<string> highScoresQuery2 =
            from score in scores
            where score > 80
            orderby score descending
            select $"The score is {score}";

            foreach (string i in highScoresQuery2)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
