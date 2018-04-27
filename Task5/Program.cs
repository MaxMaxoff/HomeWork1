using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к уроку 1.
/// 
/// Задание 5:
/// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
/// б) Сделать задание, только вывод организуйте в центре экрана
/// в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
/// </summary>
namespace Task5
{
    class Program
    {
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
            //a
            Console.WriteLine("Простой вывод");
            Console.WriteLine("Максим");
            Console.WriteLine("Торопов");
            Console.WriteLine("Ярославль");
            Console.ReadLine();

            //б
            Console.Clear();
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);

            Console.WriteLine("Вывод в центре экрана");

            Console.SetCursorPosition(17, 20);
            Console.WriteLine("Максим");
            Console.SetCursorPosition(17, 21);
            Console.WriteLine("Торопов");
            Console.SetCursorPosition(16, 22);
            Console.WriteLine("Ярославль");
            Console.ReadLine();

            //в
            Console.Clear();
            Console.SetWindowSize(40, 40);
            Console.SetBufferSize(40, 40);

            Console.WriteLine("Вывод в центре экрана с использованием метода");

            Print("Максим", 17, 20);
            Print("Торопов", 17, 21);            
            Print("Ярославль", 16, 22);
            Console.ReadLine();
        }
    }
}
