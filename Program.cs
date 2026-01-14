using System;

namespace ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 1, 2, 3 };
            Console.WriteLine($"Type of Array : {array.GetType()}");
            Console.WriteLine($"Base Type Of array : {array.GetType().BaseType}");


        }
    }
}
