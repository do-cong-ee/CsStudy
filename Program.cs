using System;

namespace ConstraintOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] array { get; set; }
        public StructArray(int size)
        {
            array = new T[size];
        }
    }
    class RefArray<T> where T : class
    {
        public T[] array { get; set; } // 자동생성 프로퍼티 \
        public RefArray(int size)
        {
            array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        //Base클래스를 상속한 타입만 만들 수 있다. 
        public U[] array { get; set; }
        public BaseArray(int size)
        {
            array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(array, 0);
        }
    }
    
    class MainApp
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.array[0] = 0;
            a.array[1] = 1;
            a.array[2] = 2;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.array[0] = new StructArray<double>(5);
            b.array[1] = new StructArray<double>(10);
            b.array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.array[0] = new Base();
            c.array[1] = new Derived();
            c.array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.array[0] = new Derived();
            c.array[1] = CreateInstance<Derived>();
            d.array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.array);
        }
    }
    
}