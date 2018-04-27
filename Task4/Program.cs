using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к уроку 1.
/// 
/// Задание 4:
/// Написать программу обмена значениями двух переменных
/// а) с использованием третьей переменной;
/// б) * без использования третьей переменной.
/// </summary>
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое значение: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе значение: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int str1 = a;
            int str2 = b;

            //Обмен целочисленных значений через промежуточную переменную
            int buff = 0;
            buff = str2;
            str2 = str1;
            str1 = buff;
           
            
            Console.WriteLine($"Результат обмена переменных через промежуточную переменную: первое значение {str1}, второе значение {str2}");
            Console.ReadLine();

            str1 = a;
            str2 = b;

            //Обмен целочисленных значений без промежуточной переменной, используя XOR
            str1 ^= str2;
            str2 ^= str1;
            str1 ^= str2;
            Console.WriteLine($"Результат обмена переменных с использованием XOR: первое значение {str1}, второе значение {str2}");
            Console.ReadLine();

            str1 = a;
            str2 = b;

            //Обмен целочисленных значений без промежуточной переменной, возможно переполнение.
            str1 = str1 + str2;
            str2 = str1 - str2;
            str1 = str1 - str2;
            Console.WriteLine($"Результат обмена переменных через сумму, возможно переполнение: первое значение {str1}, второе значение {str2}");
            Console.ReadLine();
        }
    }
}
