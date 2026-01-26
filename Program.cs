using System;

namespace DuckTyping
{
    class Duck
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + ".walk");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType() + ".swim");
        }
        public void Quack()
        {
            Console.WriteLine(this.GetType() + ".quack");
        }
    }

    class Mallard : Duck
    {
    }

    class Robot
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + ".walk");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType() + ".swim");
        }
        public void Quack()
        {
            Console.WriteLine(this.GetType() + ".quack");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            dynamic[] arr = new dynamic[3] { new Duck(), new Mallard { }, new Robot() };
            //Duck[] arr2 = new Duck[3] { new Duck(), new Mallard { }, new Robot() };
            foreach (dynamic duck in arr)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Quack();

                Console.WriteLine();
            }
        }
    }
}