using System;

namespace using_action
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Action<string> act = (string message) => { Console.WriteLine(message); };

            act("Hello World!");
        }
    }
}