using System;

namespace EventTest
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;
        public void DoSomeThing(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappened(string.Format("{0} 짝", number));
            }
        }
    }

    class MainApp
    {
        static public void MyHander(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHander);
        
            for(int i=0;i<300;i++)
            {
                notifier.DoSomeThing(i);
            }
        }
    }
}