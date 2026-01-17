using System;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            this.array = new T[3];
        }

        public T this[int index]
        {
            //e.g of Indexer
            get 
            {
                return this.array[index];
            }
            set
            {
                if(index>=array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length //자동구현 프로퍼티... 
        {
            get { return array.Length;  }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jfl";
            str_list[4] = "mno";
            // array 에 접근 하는 방식으로 class 의 object 의 member 에 접근가능..
            // 인덱서의 힘? 
            for(int i=0;i<str_list.Length;i++)
            {
                Console.WriteLine(str_list[i]);
            }

        }
    }
}