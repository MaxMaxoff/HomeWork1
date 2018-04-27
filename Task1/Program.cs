using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к 1 уроку.
/// 
/// Задание 1:
/// Написать программу “Анкета”. Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
/// а) используя склеивание;
/// б) используя форматированный вывод;
/// в) * используя вывод со знаком $.
/// </summary>
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Имя: ");
            string fname = Console.ReadLine();

            Console.Write("Введите Фамилию: ");
            string lname = Console.ReadLine();

            Console.Write("Введите Возраст: ");
            string age = Console.ReadLine();

            Console.Write("Введите Рост: ");
            string height = Console.ReadLine();

            Console.Write("Введите Вес: ");
            string weight = Console.ReadLine();

            //string fname = "Максим";
            //string lname = "Торопов";
            //string age = "35";
            //string height = "177";
            //string weight = "110";

            //а
            Console.WriteLine("Склейка:");
            Console.WriteLine("Итак, мы выяснили, что Вы: " + fname + " " + lname + "; Ваш возраст: " + age + "; Ваш рост: " + height + "; и Ваш вес: " + weight);
            Console.ReadLine();

            //б
            Console.WriteLine("Форматированный вывод:");
            Console.WriteLine("Итак, мы выяснили, что Вы:{0,10} {1,10}; Ваш возраст:{2,3}; Ваш рост:{3,4}; Ваш вес:{4,4}", fname, lname, age, height, weight);
            Console.ReadLine();

            //в
            Console.WriteLine("Вывод со знаком $");
            Console.WriteLine($"Итак, мы выяснили, что Вы:{fname,10} {lname,10}; Ваш возраст:{age,3}; Ваш рост:{height,4}; Ваш вес:{weight,4}");
            Console.ReadLine();
        }
    }
}
