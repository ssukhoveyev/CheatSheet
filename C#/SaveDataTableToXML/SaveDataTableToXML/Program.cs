using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDataTableToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dt = new DataTable("table1");
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("qu", typeof(int));

            DataRow dr = dt.NewRow();
            dr["name"] = "Имя 1";
            dr["qu"] = 10;
            dt.Rows.Add(dr);

            DataRow dr1 = dt.NewRow();
            dr1["name"] = "Имя 2";
            dr1["qu"] = 20;
            dt.Rows.Add(dr1);

            StringWriter writer = new StringWriter();
            dt.WriteXml(writer, XmlWriteMode.WriteSchema, false);

            string str = writer.ToString();

            Console.WriteLine(str);

            //Загружаем таблицу из XML

            DataTable dt2 = new DataTable();
            byte[] bArr = Encoding.UTF8.GetBytes(str);
            MemoryStream xmlStream = new MemoryStream(bArr);
            dt2.ReadXml(xmlStream);

            Console.WriteLine("Строк в загруженной таблице: " + dt2.Rows.Count);
            foreach (DataRow drs in dt2.Rows)
                Console.WriteLine($"{drs["name"]} - {drs["qu"]}");

            Console.ReadKey();
        }
    }
}
