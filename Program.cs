using System;

namespace MyProgram
{   
    class MainApp
    {
        public static Int64 Pivo_Nazi(int idx)
        {
            if(idx == 0)
            {
                return 0;
            }
            else if(idx == 1)
            {
                return 1;
            }
            else
            {
                return Pivo_Nazi(idx-1) + Pivo_Nazi(idx - 2);
            }
        }

        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Pivo_Nazi(n));

        }
    }
}