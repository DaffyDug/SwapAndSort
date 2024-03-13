using System;

namespace SwapAndSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ReverseArray(vs);

            MergeArrays(vs, vs);
        }
        public static void ReverseArray(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            int j = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[j];
                j--;
                Console.WriteLine($"{reversedArray[i]}");
            }
        }
        public static void MergeArrays(int[] array1, int[] array2)
        {
            int[] MegaArray = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                MegaArray[i] = array1[i];
            }
            for (int i = 0; i < array2.Length; i++)
            {
                MegaArray[i + array1.Length] = array2[i];
            }
            for (int i = 0; i < MegaArray.Length; i++)
            {
                Console.Write($"{MegaArray[i]}\t");
            }

            //Array.Copy(array1, MegaArray, array1.Length);
            //Array.Copy(array2, 0, MegaArray, array1.Length, array2.Length);

        }
    }
}