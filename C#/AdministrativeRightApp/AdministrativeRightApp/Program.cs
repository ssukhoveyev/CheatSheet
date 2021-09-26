using System;
using System.Security.Principal;

namespace AdministrativeRightApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            if (hasAdministrativeRight)
            {
                Console.WriteLine("Запущено с правами администратора.");
            }
            else
            {
                Console.WriteLine("Необходимы права администратора.");
            }

            Console.ReadKey();
        }
    }
}
