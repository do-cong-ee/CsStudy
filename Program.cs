using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskResult
{
    class MainApp
    {   
        static bool IsPrime(long number) //소수를 찿는 함수
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for(long i =0;i<number;i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);
            int taskCount = Convert.ToInt32(args[2]);

            Func<object, List<long>> FindPrimeFunc = (objRange) =>
            {
                long[] range = (long[])objRange;
                List<long> found = new List<long>();

                for(long i = range[0]; i < range[1];i++)
                {
                    if (IsPrime(i))
                        found.Add(i);
                }

                return found;
            }; //대리자를 이용한 무명함수 


            //Task<List<long>> tasks = new Task<List<long>>();
            // Task(함수,함수의 인자) 를!

            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to / taskCount;

            for(int i=0;i<taskCount;i++)
            {
                Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);
                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[]{ currentFrom, currentTo });
                
            }

        }
    }
}