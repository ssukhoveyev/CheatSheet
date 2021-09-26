using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Md5App
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "123123";

            using (MD5 md5Hash = MD5.Create())
            {
                string mdHash = GetMd5Hash(md5Hash, pass);
                Console.WriteLine(mdHash);
            }

            Console.ReadKey();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}
