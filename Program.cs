using System;

namespace ArraySample2
{
    class MainApp
    {
        static void PrintArray(System.Array array)
        {
            foreach (var e in array)
                Console.Write(e);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            char[] array = new char[26];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = (char)('A' + i);
            }

            PrintArray(array[..]);
            PrintArray(array[3..]);
            PrintArray(array[..16]);
            PrintArray(array[0..4]);

            System.Range range_5_10 = 5..10;
            PrintArray(array[range_5_10]);

            System.Index last = ^0;
            System.Range range_5_last = 5..last;
            PrintArray(array[range_5_last]);

            PrintArray(array[^4..^1]);

            return;
        }

        
    }
}
