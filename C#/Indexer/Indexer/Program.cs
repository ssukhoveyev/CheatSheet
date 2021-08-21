using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        //Индексаторы в C# позволяют индексировать объекты и обращаться к данным по индексу точно также,
        //как в массивах. По своей форме индексатор поход на свойство со стандартными блоками get и set,
        //которые возвращают и присваивают значение.

        static void Main(string[] args)
        {

            People people = new People();
            people[0] = new Person { Name = "Tom" };
            people[1] = new Person { Name = "Bob" };

            Person tom = people[0];
            Console.WriteLine(tom?.Name);

            //Или так
            Console.WriteLine(people[1].Name);

            Console.ReadKey();
        }

        class Person
        {
            public string Name { get; set; }
        }
        class People
        {
            Person[] data;
            public People()
            {
                data = new Person[5];
            }
            // индексатор
            public Person this[int index]
            {
                get
                {
                    return data[index];
                }
                set
                {
                    data[index] = value;
                }
            }
        }
    }
}
