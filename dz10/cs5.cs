using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class cs5
    {
        public static void task_5()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int[] numbers = { -1, 2, -3, 4, -1, -3, 5, 6 };

            var uniqueNegatives = numbers.Where(n => n < 0).Distinct();
            Console.WriteLine("Унікальні числа меньші 0:");
            foreach (var num in uniqueNegatives)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }
    }
}
