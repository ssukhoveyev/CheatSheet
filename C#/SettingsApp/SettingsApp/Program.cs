using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettingsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Properties.Settings.Default.MyString = "111";
            Properties.Settings.Default.Save();
        }
    }
}
