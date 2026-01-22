using System;
using System.Linq;

namespace FromEx
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n
                         select n;

            foreach (var element in result)
            {
                Console.WriteLine($"{element}");
            }
        }
    }
}