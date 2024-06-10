namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worl!");
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
    }
}
