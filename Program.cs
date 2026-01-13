using System;

namespace Property
{
   record Transaction
    // public class 대신 record 를 쓴다.. 왜?
    // 레코드는 참조형식이면서 비교할때는 값형식처럼 쓸 수 있어서...
    // 참조형식 -> 빨라 값형식 ->느려,,, 빠르면서 비교쉽게? 
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

            Transaction tr4 = tr3 with { To = "꺼억이" };
            Transaction tr5 = tr4 with { From = "뿡뿡이" };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
            Console.WriteLine(tr4);
            Console.WriteLine(tr5);

            return;

        }
    }
}