using System;
using System.IO;

namespace chu_sang_class
{
   abstract class AbstractBase
    {
        protected void PrivateMathodA()
        {
            Console.WriteLine("AbstractBase.PrivateMathod()");
        }

        public void PublicMathodA()
        {
            Console.WriteLine("AbstractBase.PublicMathodA()");
        }

        public abstract void AbstractMathodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMathodA()
        {
            Console.WriteLine("Derived.AbstractMathodA()");
            PrivateMathodA();
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMathodA();
            obj.PublicMathodA();
        }
    }
}