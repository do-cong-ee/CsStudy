using System;

namespace PartialClass
{
    partial class MyClass
    {
        public void Mathod1() { Console.WriteLine("Mathod1"); }
        public void Mathod2() { Console.WriteLine("Mathod2"); }
        public void Mathod3() { Console.WriteLine("Mathod3"); }
    }


    partial class MyClass
    {
        public void Mathod4() { Console.WriteLine("Mathod4"); }
        public void Mathod5() { Console.WriteLine("Mathod5"); }
        public void Mathod6() { Console.WriteLine("Mathod6"); }
    }


    class MainApp
    {
        static void Main(string[] args)
        {

        }
    }
}