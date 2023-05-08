using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] numbers = { 7, 14, 21, 28, 35, 42, 49, 56 };

            int count = numbers.Count(n => n % 7 == 0);

            Console.WriteLine($"Кількість чисел у масиві, кратних 7: {count}");
            Console.WriteLine();
        }
    }
}
