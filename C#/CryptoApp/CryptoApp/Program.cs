using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "111";

            Console.WriteLine("Введите строку:");
            string st = Console.ReadLine();
            Console.WriteLine("Введенная строка: " + st);

            byte[] criptByte = Encrypt(st, password);

            string encoded = System.Convert.ToBase64String(criptByte);
            Console.WriteLine("Зашифрованная строка: " + encoded);
            criptByte = System.Convert.FromBase64String(encoded);

            string decryptString = Decrypt(criptByte, password);

            Console.WriteLine("Расшифрованная строка: " + decryptString);

            Console.ReadKey();
        }

        static public byte[] Encrypt(string dataString, string password)
        {
            byte[] key, IV;

            byte[] encrypted; ;

            key = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");
            IV = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");

            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = key;
                rijAlg.IV = IV;

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(dataString);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        static public string Decrypt(byte[] cryptByte, string password)
        {
            byte[] key, IV;

            key = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");
            IV = Convert.FromBase64String("AAECAwQFBgcICQoLDA0ODw==");

            string decryptString = null;

            using (Rijndael rijAlg = Rijndael.Create())
            {
                rijAlg.Key = key;
                rijAlg.IV = IV;
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cryptByte))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decryptString = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return decryptString;
        }
    }
}
