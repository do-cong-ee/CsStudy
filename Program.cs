using System;

namespace EventTest
{
    delegate void EventHandler(string message); //일단 대리자 하나 만들어 

    class MyNotifier //클래스 생성 
    {
        public event EventHandler SomethingHappened; // 만든 대리자를 형식으로 하는 이벤트 리스너 하나 만들어
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(String.Format("{0} : 짝", number)); //조건이 맞다면 ->delegate 로 생성된 이벤트 처리 함수 call 한다..
            }
        }
    }

    class MainApp
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}

}
