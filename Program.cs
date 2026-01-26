using System;

namespace MyAttribute
{
    class MyClass
    {
        [Obsolete("OldMethod 는 버려졌읍니다, NewMethod()를 이용하셔요 아이고난1 아이고난2 뭉탱이")]
        public void OldMethod()
        {
            Console.WriteLine("I am Old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I am new");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.OldMethod();
            myclass.NewMethod();
        }
    }
}