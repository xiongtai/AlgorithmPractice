using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    static class Sorting
    {
        public static void BubbleSorting(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        array.Swap(j, j + 1);
                    }
                }
            }
        }
        static void Swap(ref int one, ref int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }

        static void Swap(this int[] array, int one, int two)
        {
            int temp = array[one];
            array[one] = array[two];
            array[two] = temp;
        }

        static void MergeArray(int[] array)
        {
            
        }

        static void SplitArray(int[] array1,int[] array2)
        {

        }

        static void SplitMergeArray(int[] array)
        {

        }
    }
}
