using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace CompInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT Manufacturer,Product, SerialNumber,Version FROM Win32_BaseBoard");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
            }

            Console.ReadKey();
        }
    }
}
