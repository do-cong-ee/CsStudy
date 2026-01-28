#pragma warning disable SYSLIB0006

using System;
using System.Threading;

namespace AbortingThread
{
    class SideTask
    {
        int count;
        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive(CancellationToken token)
        {
            try
            {
                while (this.count > 0)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Cancellation requested: stopping gracefully.");
                        break;  // 반복문 벗어나서 정리
                    }

                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            finally //복습, 예외가 생기든 안생기든 무조껀 실행하는 코드
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);

           

            // .NET10 에서 abort 대신 쓰는거, 취소 토큰 소스 생성
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            //Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            //t1.IsBackground = false;

            Thread t1 = new Thread(() => task.KeepAlive(token));
            t1.IsBackground = false;

            Console.WriteLine("Starting Thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Aborting Thread...");
            cts.Cancel();
            //t1.Abort();
            //  t1.Abort(); 은 .NET10 에서 사라진기능 실행하고싶다면 .NET9 에서 실행하기


            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}