using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Максим Торопов
/// Домашнее задание к уроку 1.
/// 
/// Задание 3:
/// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
/// Вывести результат используя спецификатор формата .2f (с двумя знаками после запятой);
/// б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде метода;
/// </summary>
namespace Task3
{
    class Program
    {
        static double lenr(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        
        static void Main(string[] args)
        {
            Console.Write("Введите координату X1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Х2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату Y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //а
            double r = 0;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между точками с координатами x1:{x1,2}, y1:{y1,2} и x2:{x2,2}, y2:{y2,2} равно {r:F2}");
            Console.ReadLine();

            //б
            double rr = lenr(x1, y1, x2, y2);            
            Console.WriteLine($"Расстояние между точками с координатами x1:{x1,2}, y1:{y1,2} и x2:{x2,2}, y2:{y2,2} равно {rr:F2}");
            Console.ReadLine();
        }
    }
}
