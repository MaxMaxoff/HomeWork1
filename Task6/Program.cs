using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к уроку 1.
/// 
/// Задание 6:
/// *Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
/// </summary>
namespace SupportClass
{
    class SupportMethods
    {
        static void Print(string message, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Pause(string message)
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
        
}
