using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Сергей";
            person.age = 18;


            //Сохранть обьект в XML
            using (FileStream stream = new FileStream("person.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(stream, person);
                stream.Close();
            }

            //Загрузить обьект из XML
            using (Stream stream = new FileStream("person.xml", FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                Person person2 = (Person)serializer.Deserialize(stream);
                Console.WriteLine($"Имя: {person2.name}, возраст: {person2.age}");
            }

            Console.ReadKey();
        }
    }
}
