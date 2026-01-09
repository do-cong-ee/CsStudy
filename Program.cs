using System;

namespace IInterface
{
    interface IExInterFace
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : IExInterFace
    {
        public void WriteLog(string message)
        {
            Console.WriteLine("{0}, {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IExInterFace logger = new ConsoleLogger();
            logger.WriteLog("김깝심");

            return;
        }
    }
}