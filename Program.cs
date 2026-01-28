using System;
using System.Threading;

namespace BasicThreading
{
    class MainApp
    {
        static void DoSomeThing()
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"DoSomeThing : {i}");
                //Thread.Sleep(3);
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(BasicThreading.MainApp.DoSomeThing));
            Console.WriteLine("Starting Thread...");
            t1.Start();

            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine($"Main : {i}");
                //Thread.Sleep(2);
            }

            Console.WriteLine("Waiting Until Thread Stop.....");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}