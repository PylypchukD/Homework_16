using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя Visual Studio, создайте проект по шаблону Console Application. 
             * Создайте структуру описывающую точку в трехмерной системе координат. 
             * Организуйте возможность сложения двух точек, через использование перегрузки оператора +.
             */

            Point pointA = new Point(1, 1, 1);
            Point pointB = new Point(3, 2, 1);

            Point pointC = pointA + pointB;

            Console.WriteLine($"Новая точка имеет координаты: {pointC.X} {pointC.Y} {pointC.Z}");

            Console.ReadKey();

        }
    }
}
