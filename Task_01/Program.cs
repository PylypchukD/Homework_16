using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте класс Block с 4-мя полями сторон, переопределите в нем методы: Equals – способный сравнивать блоки между собой, ToString – возвращающий информацию о полях блока. 
             */

            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(4, 3, 2, 1);

            Console.WriteLine(block1.Equals(block2));

            Console.WriteLine(block1.GetHashCode() == block2.GetHashCode());

            Console.ReadKey();
        }
    }
}
