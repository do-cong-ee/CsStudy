using System;
using System.IO;

namespace IInterface
{
    interface ILogger
    {
        void WriteLog(string path);
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string path)
        {
            writer.WriteLine("{0}, {1}", DateTime.Now.ToShortTimeString(), path);
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
          
        }
    }
}