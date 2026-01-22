using System;

namespace Rambda_sik
{
    delegate int Calculator(int a, int b);
    delegate void DoSomeThing();
    class MainApp
    {
        static int Calculator2(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
        
            Calculator calc = (a, b) => a + b;

            Console.WriteLine(calc(10,20));

            Calculator calc2 = new Calculator(Calculator2);

            Console.WriteLine(calc2(120, 20));

            DoSomeThing doit = () =>
            {
                Console.WriteLine("do some Thing");
                Console.WriteLine("like this");
            };

            doit();

            return;
        }
    }
}