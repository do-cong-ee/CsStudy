using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FileCopyAction = (object state) =>
            {
                string[] paths = (string[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine("TaskId : {0}, Thread : {1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
            };

            Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            }); // Task.Run 함수의 인자로 함수를 줘야해...

            t1.Start();
            
            Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
            {
                new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });
            };

            t3.RunSynchronously();

            t1.Wait();
            t2.Wait();
            t3.Wait();
        }
    }
}
