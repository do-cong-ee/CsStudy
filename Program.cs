using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "김철수", Age = 123 };
            Console.WriteLine($"Name : {a.Name} Age : {a.Age}");

            var b = new { Subject = "김수학", Scores = new int[] { 10,20,30,40}};

            Console.Write($"Subject {b.Subject}, Scores : ");
            foreach (var score in b.Scores)
                Console.Write("{0}", score);

            Console.WriteLine();

        }
    }
}
