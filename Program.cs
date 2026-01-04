using System;

namespace TypeCasting
{
    class Mammal
    {
        public void nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class dog : Mammal
    {
        public void bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class cat : Mammal
    {
        public void meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new dog();
            dog ddog;

            if(mammal is dog)
            {
                ddog = (dog)mammal;
                ddog.bark();
            }

            Mammal mammal2 = new cat();

            cat cat2 = mammal2 as cat;
            if(cat2 !=null)
            {
                cat2.meow();
            }

            cat cat3 = mammal as cat;
            if(cat3 != null)
            {
                cat3.meow();
            }
            else
            {
                Console.WriteLine("Cat3 is not a cat");
            }
        }
    }
}