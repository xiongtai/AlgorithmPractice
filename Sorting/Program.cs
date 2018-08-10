using System;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        public delegate void SortingMethod(int[] array);
        static void Main(string[] args)
        {
            int[] a = { 1, 3, 2, 4 };            
            Info(Sorting.BubbleSorting, a);

            Console.ReadLine();
        }

        static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
        }
        static void Info(SortingMethod sort, int[] array)
        {
            Stopwatch sp = new Stopwatch();
            sp.Start();
            for (int i = 0; i < 1000000; i++)
            {
                var test = array.Clone();
                sort.Invoke(array);
            }
            sp.Stop();
            Console.WriteLine(sp.ElapsedMilliseconds);
            PrintArray(array);
        }


    }
}
