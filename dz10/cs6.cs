using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class cs6
    {
        public static void task_6()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Func<string, string, bool> checkWord = (text, word) => text.Contains(word);

            string text = "Це рядок з декількома словами.";
            string word = "декількома";

            bool containsWord = checkWord(text, word);

            Console.WriteLine($"Рядок '{text}' містить слово '{word}': {containsWord}");
        }
    }
}
