using System;
using System.Diagnostics;
using System.Security;
using Microsoft.Win32;

//1. Написать программу, которая показывает дату и время ее запуска и при этом прописывает себя
//   в раздел автозапуска HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run.


namespace HW1_1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine(DateTime.Now);

                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
                {
                    key.SetValue($"{Process.GetCurrentProcess().MainModule.ModuleName.Replace(".exe", "")}", $"\"{Process.GetCurrentProcess().MainModule.FileName}\"");
                }

                Console.ReadKey();
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException un)
            {
                Console.WriteLine(un.Message);
            }
        }
    }
}
