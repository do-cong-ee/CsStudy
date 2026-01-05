using System;

namespace Override
{
    class ArmorSuites
    {
        public virtual void Initialize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuites
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuites
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("double");
            Console.WriteLine("rocket");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            console
        }
    }

}