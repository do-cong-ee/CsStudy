using System;
using System.Collections;
using System.Collections.Generic;

namespace Throw
{
    class MainApp
    {
       static void DoSomeThing(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다");
        }

        static void Main(string[] args)
        {
            try
            {
                DoSomeThing(1);
                DoSomeThing(3);
                DoSomeThing(5);
                DoSomeThing(7);
                DoSomeThing(9);
                DoSomeThing(11);
                DoSomeThing(13); // 26행에서 예외 생겨서 여기는 실행안됨.
            }
            catch (Exception e)
            {
                //Method 에서 exception 을 throw 하면 call 한 위치에서 catch 한다.
                Console.WriteLine(e.Message);
            }
        }
    }
}