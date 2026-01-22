using System;

namespace using_action
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Action<string> act = (string message) => { Console.WriteLine(message); };

            act("Hello World!");

            int result=0;

            Action<int, int> act2 = (int a, int b) => { result = a + b; };
            act2(20, 20);
            Console.WriteLine(result);

            Action action = new action(delegate () { Console.WriteLine(a * a)});

            Action action = (int a) => { Console.WriteLine(a*a)};
        }
    }
}

