using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class MainApp
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C"); //3
            Console.WriteLine("D"); //4

            await Task.Run(async () =>
            {
                for(int i=1;i<=count;i++)
                {
                    Console.WriteLine($"{i}/{count}...");
                    await Task.Delay(700);
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {
            Console.WriteLine("A"); //1
            Console.WriteLine("B"); //2

            MyMethodAsync(3);

            Console.WriteLine("E"); //5
            Console.WriteLine("F"); //6
        }


        static void Main(string[] args)
        {
            Caller();
            Console.ReadLine();
        }
    }
}