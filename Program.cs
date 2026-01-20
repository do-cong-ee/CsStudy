using System;

namespace UsingCallBack
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] arr, Compare Comparer)
        {
            int i = 0, j = 0, temp = 0;

            for (i = 0; i < arr.Length; i++)
            {
                for (j = 0; j < arr.Length - (i + 1); i++)
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
            BubbleSort(array, new Compare(AscendCompare));
        }
    }
}