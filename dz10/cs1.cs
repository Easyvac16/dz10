using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
    internal class cs1
    {
        public static void task_1()
        {
            string color = "red";

            // Анонімний метод, 
            Func<string, (int r, int g, int b)> getRGB = (c) =>
            {
                switch (c)
                {
                    case "red": return (255, 0, 0);
                    case "orange": return (255, 165, 0);
                    case "yellow": return (255, 255, 0);
                    case "green": return (0, 128, 0);
                    case "blue": return (0, 0, 255);
                    case "indigo": return (75, 0, 130);
                    case "violet": return (238, 130, 238);
                    default: return (0, 0, 0); // Повернути чорний колір для невідомих кольорів
                }
            };

            // Виклик анонімного методу 
            
            var rgb = getRGB(color);
            Console.WriteLine($"RGB values for {color} are ({rgb.r}, {rgb.g}, {rgb.b})");

            color = "yellow";
            Console.WriteLine($"RGB values for {color} are ({rgb.r}, {rgb.g}, {rgb.b})");

            color = "green";
            rgb = getRGB(color);
            Console.WriteLine($"RGB values for {color} are ({rgb.r}, {rgb.g}, {rgb.b})");

            color = "purple";
            rgb = getRGB(color);
            Console.WriteLine($"RGB values for {color} are ({rgb.r}, {rgb.g}, {rgb.b})");
            Console.WriteLine();
        }
    }
}
