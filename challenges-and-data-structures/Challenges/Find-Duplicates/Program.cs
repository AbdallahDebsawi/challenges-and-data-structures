using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Find_Duplicates
{
    internal class DuplicateFinder
    {
        static void Main(string[] args)
        {
            int[] test1 = { 1, 2, 3, 1, 2, 3 };
            int[] result1 = DuplicateFinder.FindDuplicates(test1);
            Console.WriteLine(string.Join(", ", result1)); 

            int[] test2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] result2 = DuplicateFinder.FindDuplicates(test2);
            Console.WriteLine(string.Join(", ", result2)); 

            int[] test3 = { 5, 10, 16, 20, 10, 16 };
            int[] result3 = DuplicateFinder.FindDuplicates(test3);
            Console.WriteLine(string.Join(", ", result3)); 
        }

        public static int[] FindDuplicates(int[] input)
        {
            List<int> seenValues = new List<int>();
            List<int> duplicates = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (Contains(seenValues, input[i]))
                {
                    if (!Contains(duplicates, input[i]))
                    {
                        duplicates.Add(input[i]);
                    }
                }
                else
                {
                    seenValues.Add(input[i]);
                }
            }

            return ToArray(duplicates);
        }

        private static bool Contains(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        private static int[] ToArray(List<int> list)
        {
            int[] array = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
    }

}

