using System;

namespace StatementLambda
{
    class MainApp
    {
        delegate string Concatenate(string[] str);

        static void Main(string[] args)
        {
            Func<int> func1 = () => { return 10; };
            Console.WriteLine(func1());

            Func<int, int> func2 = (int a) => { return a * 2; };

            Console.WriteLine(func2(20));

            Func<int, int, int> func3 = (int a, int b) => { return a<<b; };
            Console.WriteLine(func3(10, 3));
        }
    }
}