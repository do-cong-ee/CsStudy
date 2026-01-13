using System;

namespace Property
{
   public class Transaction
    {
        public string From { get; init;}
        public string To { get; init; }
        public int Amount { get; init;}
        //초기화 전용 자동 구현 프로퍼티

        public override string ToString()
        {
            return $"{From,10} -> {To,10} : ${Amount}";
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Transaction tr1 = new Transaction
            {
                From = "춘식이",
                To = "대식이",
                Amount = 1000
            };
            Transaction tr2 = new Transaction
            {
                From = "개똥이",
                To = "말똥이",
                Amount = 2000
            };
            Transaction tr3 = new Transaction
            {
                From = "얼렁이",
                To = "뚱땅이",
                Amount = 3000
            };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);

            return;

        }
    }
}