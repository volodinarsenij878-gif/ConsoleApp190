using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program41
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Количество страниц: ");
            if (int.TryParse(Console.ReadLine(), out int pages))
            {
                if (pages > 100)
                    Console.WriteLine("Включена двухсторонняя печать.");
                else
                    Console.WriteLine("Односторонняя печать.");
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}
