using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Common_Elements
{
    public class CommonElement
    {
        public static void TestCommonElements(int[] arr1, int[] arr2)
        {
            Console.WriteLine($"Input 1: [{string.Join(", ", arr1)}]");
            Console.WriteLine($"Input 2: [{string.Join(", ", arr2)}]");
            List<int> result = CommonElements(arr1, arr2);
            Console.WriteLine($"Output: [{string.Join(", ", result)}]");
            Console.WriteLine();
        }
        public static List<int> CommonElements(int[] arr1, int[] arr2)
        {
            List<int> commonElements = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j] && !commonElements.Contains(arr1[i]))
                    {
                        commonElements.Add(arr1[i]);
                    }
                }
            }

            return commonElements;
        }
    }
}
