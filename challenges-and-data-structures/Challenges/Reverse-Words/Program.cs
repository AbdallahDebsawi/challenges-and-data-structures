using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Challenges.Reverse_Words
{
    public class ReverseWords
    {
        public static string ReverseWord(string s)
        {
            string[] words = s.Split(' ');
            Array.Reverse(words);
            string reversedString = string.Join(" ", words);
            return reversedString;
        }
    }
}
