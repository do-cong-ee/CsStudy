using System;
using System.Collections;
using System.Collections.Generic;

namespace ThrowException
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int? a=null; //nullable 
                int b = a ?? throw new ArgumentNullException();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"{e}");
            }

            try
            {
                int[] array = new int[] { 1, 2, 3 };
                int index = 4;
                int value = array[
                    index >= 0 && index < 4 ? index : throw new IndexOutOfRangeException()
                    ];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}