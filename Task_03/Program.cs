using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте класс, который будет содержать информацию о дате (день, месяц, год). 
             * С помощью механизма перегрузки операторов, определите операцию разности двух дат (результат в виде количества дней между датами), 
             */

            Console.WriteLine(MyDateTime.Sub(new MyDateTime( new DateTime(2022,10,06) ), 
                                             new MyDateTime( new DateTime(2022,01,01) )));

            Console.ReadKey();
        }
    }
}
