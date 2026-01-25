using System;
using System.Collections.Generic;
using System.Linq;


namespace FromFrom
{
    class Class
    {
        public string name { get; set; }
        public int[] score { get; set; }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class(){name = "연두반", score = new int[] {99,88,70,24}},
                new Class(){name="초록반", score = new int[]{60,45,87,72 } },
                new Class(){name="파랑반", score = new int[]{92,30,85,94 } },
                new Class(){name="노랑반", score = new int[]{90,88,0,17 } }

            };

            var classes = from c in arrClass
                          from s in c.score
                          where s < 60
                          orderby s
                          select new { c.name, lowest = s };

            foreach (var c in classes)
            {
                Console.WriteLine($"낙제 : {c.name} ({c.lowest})");
            }
        }
    }
}