using System;
using System.Collections;

namespace ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for(int i=0;i<5;i++)
            {
                list.Add(i);
                // 리스트 뒤에 추가하는 함수..
            }

            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
            {
                Console.Write($"{obj} ");
            }
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for(int i=0;i<list.Count;i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine();
        }
    }
}
