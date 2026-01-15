using System;

namespace ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            // 행의 갯수만 지정..

            jagged[0] = new int[5]{1,2,3,4,5};
            jagged[1] = new int[3] {10,20,30};
            jagged[2] = new int[2] {100,200};

            foreach(int[] arr in jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach(int element in arr)
                {
                    Console.Write($" {element}");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("-----");

            int[][] jagged2 = new int[2][]
            {
                new int[]{1000,2000 },
                new int[4]{6,7,8,9}
            };


            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length : {arr.Length} ,");
                foreach (int element in arr)
                {
                    Console.Write($" {element}");
                }
                Console.WriteLine("");
            }

        }
    }
}
