using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Threading;
using System.Diagnostics;

namespace CompInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseBoard();

            //CPUTime();

            Fan();

            //VideoController();

            //CPUTemp();

            Console.ReadKey();
        }

        static void BaseBoard()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT Manufacturer,Product, SerialNumber,Version FROM Win32_BaseBoard");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
            }
        }

        public static void CPUTime()
        {
            using (var pc = new PerformanceCounter("Processor", "% Processor Time", "_Total"))
            {
                int i = 0;
                while (i < 4)
                {
                    Console.WriteLine(pc.NextValue());
                    Thread.Sleep(1000);
                    i++;
                }
            }
        }

        public static void Fan()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_Fan");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
            }
        }

        public static void VideoController()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT Caption, AdapterRAM FROM Win32_VideoController");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
            }
        }

        public static void CPUTemp()
        {
            //CurrentTemperatureRaw*0.1 - 273.15

            ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\WMI",
                "SELECT * FROM MSAcpi_ThermalZoneTemperature");
            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                    Console.WriteLine("{0} = {1}", data.Name, data.Value);
            }
        }
    }
}
