using System;

namespace ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 10;
            scores[1] = 20;
            scores[2] = 30;
            scores[^2] = 40;
            scores[^1] = 50;

            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }


        }
    }
}
