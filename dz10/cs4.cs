using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class cs4
    {
        public static void task_4()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] numbers = { 5 ,-3 ,15 ,66 ,-1 ,16 ,-61 ,3 };

            int count = numbers.Count(n => n > 0);

            Console.WriteLine($"Кількість чисел у масиві, більших 0: {count}");
            Console.WriteLine();
        }
    }
}
