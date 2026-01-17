using System;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;

        public MyList()
        {
            this.array = new T[3];
        }

        public T this[int index]
        {

        }
    }
}