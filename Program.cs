using System;

namespace ArraySample2
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }
        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };
            foreach (int score in scores)
                Console.Write($"{score}");
            Console.WriteLine();

            Array.Sort(scores);
            // 정렬하는 함수
            Array.ForEach<int>(scores, new Action<int>(Print));
            // 각각의 요소에 작업을 시행함
            Console.WriteLine();

            Console.WriteLine($"Number of Dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search : 81 is at " + $"{Array.BinarySearch<int>(scores, 81)}");

            Console.WriteLine($"Liner Search : 90 is at " + $"{Array.IndexOf(scores,90)}");

            Console.WriteLine($"Everyone passed? : " + $"{Array.TrueForAll<int>(scores,CheckPassed)}");

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3);
        
            Array.ForEach<int>(sliced, new Action<int>(Print));


        }
    }
}
