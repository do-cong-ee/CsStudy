using System;
using System.Collections;
using System.Collections.Generic;

namespace KillingProgram
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{arr[i]}");
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}