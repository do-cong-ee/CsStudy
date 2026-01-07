using Microsoft.VisualBasic;
using System;
using System.Net.Cache;

namespace PosisionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2,
                ("학생", _) => 0.1,
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05,
                _ => 0,
            };
        }       
        
        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charli = (job: "일반", age: 17);
            var dave = (job: "일반", age: 21);

            Console.WriteLine($"alice : {GetDiscountRate(alice)}");
            Console.WriteLine($"alice : {GetDiscountRate(bob)}");
            Console.WriteLine($"alice : {GetDiscountRate(charli)}");
            Console.WriteLine($"alice : {GetDiscountRate(dave)}");

        }


    }
}