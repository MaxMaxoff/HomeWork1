using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к уроку 1.
/// 
/// Задание 2:
/// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h*h); где m-масса тела в килограммах, h - рост в метрах
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Введите Рост в см: ");
            double height = Convert.ToDouble(Console.ReadLine());
            height = height / 100;

            Console.Write("Введите Вес в кг: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            //double height = 1.77;
            //int weight = 110;

            double indexm = 0;
            indexm = weight / (height * height);

            Console.WriteLine($"Индекс массы тела: {indexm:0.00}");
            Console.ReadLine();
        }
    }
}
