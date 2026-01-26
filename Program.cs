using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MyDynamic
{
    class MyClass
    {
        public void FuncAAA()
        {
            //do not thing
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            dynamic obj = new MyClass();
            obj.FuncAAA();
            obj.FuncBBB();
        }
    }
}