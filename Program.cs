using System;
using System.Collections;

namespace UsingQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = 1;
            ht["둘"] = 2;
            ht["셋"] = 3;
            ht["넷"] = 4;
            ht["다섯"] = 5;

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);


            int[] arr = new int[3]{ 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            //배열을 인자로 입력해 줄 수 도 있다.
            Stack stack = new Stack(arr);
            //stack 도
            Queue queue = new Queue(arr);
            //queue 도

            
        }
    }
}
