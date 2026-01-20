using System;

namespace UsingCallBack
{
    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        static int DescendCompare<T>(T a, T b) where T: IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] arr, Compare<T> Comparer)
        {
            int i = 0, j = 0;
            T temp;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length - (i + 1); j++)
                {
                    if (Comparer(arr[j], arr[j + 1]) > 0)
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 7, 4, 2, 10 };
            Console.WriteLine("Ascending");
            BubbleSort(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("Descending");
            BubbleSort(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
        }
    }
}