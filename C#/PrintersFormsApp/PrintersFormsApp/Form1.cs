using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintersFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectDefPrinter_Click(object sender, EventArgs e)
        {
            SetPrinterToDefault(@"HP LaserJet 1018");

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();

            if (printDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
            }
        }

        public static bool SetPrinterToDefault(string printer)
        {
            //path we need for WMI
            string queryPath = "win32_printer.DeviceId='" + printer + "'";

            try
            {
                //ManagementObject for doing the retrieval
                ManagementObject managementObj = new ManagementObject(queryPath);

                //ManagementBaseObject which will hold the results of InvokeMethod
                ManagementBaseObject obj = managementObj.InvokeMethod("SetDefaultPrinter", null, null);

                //if we're null the something went wrong
                if (obj == null)
                    throw new Exception("Unable to set default printer.");

                //now get the return value and make our decision based on that
                int result = Convert.ToInt32(obj.Properties["ReturnValue"].Value);

                if (result == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void buttonPrinterList_Click(object sender, EventArgs e)
        {
            ManagementScope objScope = new ManagementScope(ManagementPath.DefaultPath); //For the local Access
            objScope.Connect();

            SelectQuery selectQuery = new SelectQuery();
            selectQuery.QueryString = "Select * from win32_Printer";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(objScope, selectQuery);
            ManagementObjectCollection MOC = MOS.Get();

            string printers = String.Empty;
            foreach (ManagementObject mo in MOC)
                printers += mo["Name"].ToString() + Environment.NewLine;

            MessageBox.Show(printers);
        }
    }
}
