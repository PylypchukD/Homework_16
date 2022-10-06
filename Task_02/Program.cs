using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте класс House c двумя полями и свойствами. Создайте два метода Clone() и DeepClone(), 
             * которые выполняют поверхностное и глубокое копирование соответственно. Реализуйте простой способ проверки.
             */

            House house = new House("Antonovicha, 33b", new City("Kyiv"));
            House houseClone = house.Clone();
            House houseClone2 = house.DeepClone();

            Console.WriteLine($"New:       {house.Address} {house.City.Name}");
            Console.WriteLine($"Clone:     {houseClone.Address} {houseClone.City.Name}");
            Console.WriteLine($"DeepClone: {houseClone2.Address} {houseClone2.City.Name}");


            houseClone.Address = "Svitla, 4";
            houseClone.City = new City("Harkiv");
            
            houseClone2.Address = "Centralna, 4";
            houseClone2.City = new City("Lviv");

            Console.WriteLine("");
            Console.WriteLine($"New:       {house.Address} {house.City.Name}");
            Console.WriteLine($"Clone:     {houseClone.Address} {houseClone.City.Name}");
            Console.WriteLine($"DeepClone: {houseClone2.Address} {houseClone2.City.Name}");

            Console.ReadKey();

        }
    }
}

