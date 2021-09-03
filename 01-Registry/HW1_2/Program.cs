using System;
using System.Collections.Generic;
using System.Security;
using Microsoft.Win32;

//2. Написать программу, которая сохраняет/считывает в реестре список строк.Реализовать два варианта:
//     - с использованием значение Count для обозначения количества строк;
//     - без использования значения Count для обозначения количества строк
//       (в этом случае для считывания необходимо перебрать все значения в указанном ключе).

namespace HW1_2
{
    class Program
    {
        static public void FirstVariant()
        {
            const string path = @"Software\MyKeyFirstVariant";
            var listForSave = new List<string>
            {
                @"String1",
                @"String2",
                @"String3",
                @"String4",
                @"String5"
            };

            try
            {
                using (RegistryKey keyForSave = Registry.CurrentUser.CreateSubKey(path))
                {
                    int count = 0;

                    foreach (var item in listForSave)
                        keyForSave.SetValue($"{count++}", item);
                }

                var listForLoad = new List<string>();
                using (RegistryKey keyForLoad = Registry.CurrentUser.OpenSubKey(path, false))
                {
                    foreach (var item in keyForLoad.GetValueNames())
                        listForLoad.Add(keyForLoad.GetValue(item).ToString());

                    foreach (var item in listForLoad)
                        Console.WriteLine(item);
                }
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

        static public void SecondVariant()
        {
            const string path = @"Software\MyKeySecondVariant";
            var listForSave = new List<string>
            {
                @"String1",
                @"String2",
                @"String3",
                @"String4",
                @"String5"
            };

            try
            {
                using (RegistryKey keyForSave = Registry.CurrentUser.CreateSubKey(path))
                {
                    int i = 0;

                    keyForSave.SetValue("Count", listForSave.Count, RegistryValueKind.DWord);
                    foreach (var item in listForSave)
                        keyForSave.SetValue($"{i++}", item);
                }

                var listForLoad = new List<string>();

                using (RegistryKey keyForLoad = Registry.CurrentUser.OpenSubKey(path, false))
                {
                    int count = (int)keyForLoad.GetValue("Count", RegistryValueKind.DWord);

                    for (int j = 0; j < count; j++)
                        listForLoad.Add((string)keyForLoad.GetValue($"{j}"));

                    foreach (var item in listForLoad)
                        Console.WriteLine(item);
                }
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

        static void Main()
        {
            FirstVariant();
            SecondVariant();
        }
    }
}
