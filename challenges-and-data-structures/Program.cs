﻿using challenges_and_data_structures.Challenges.Common_Elements;
namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommonElement.TestCommonElements(new int[] { 1, 2, 3, 0 }, new int[] { 2, 3, 4, 9 });
            CommonElement.TestCommonElements(new int[] { 79, 8, 15 }, new int[] { 23, 79, 8 });
            CommonElement.TestCommonElements(new int[] { 5, 10, 15, 20 }, new int[] { 10, 15, 25 });
            CommonElement.TestCommonElements(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
            CommonElement.TestCommonElements(new int[] { }, new int[] { 1, 2, 3 });
        }


        public static int[] MiddleValue(int[] array, int value)
        {
            int length = array.Length;
            int midIndex = length / 2;
            int[] newArray = new int[length + 1];

            for (int i = 0; i < midIndex; i++)
            {
                newArray[i] = array[i];
            }
            newArray[midIndex] = value;

            for (int i = midIndex; i < length; i++)
            {
                newArray[i + 1] = array[i];
            }
            return newArray;
        }

        static int MostFrequentNumber(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            Dictionary<int, int> frequency = new Dictionary<int, int>();
            int maxCount = 0;
            int mostFrequent = array[0];

            foreach (int num in array)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }

                if (frequency[num] > maxCount)
                {
                    maxCount = frequency[num];
                    mostFrequent = num;
                }
            }

            return mostFrequent;
        }

        static int[] arrayReversal(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[i] = array[array.Length - 1 - i];
                Console.WriteLine(reversedArray[i]);
            }
            return reversedArray;
        }

        static int MaximumValue(int[] array)
        {
            if (array.Length == 0)
            {
                throw new ArgumentException("Array cannot be empty.");
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
         static int[] RemoveMiddleValue(int[] arr)
        {
            int length = arr.Length;
            if (length == 0)
            {
                return arr; // Return the array as is if it's empty
            }

            int middle = length / 2;
            int count = (length % 2 == 0) ? 2 : 1;

            int[] result = new int[length - count];
            for (int i = 0, j = 0; i < length; i++)
            {
                if (i != middle && (length % 2 == 0 && i != middle - 1))
                {
                    result[j++] = arr[i];
                }
            }

            return result;
        }

    }
}
