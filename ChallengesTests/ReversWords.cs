using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenges_and_data_structures.Challenges.Reverse_Words;

namespace ChallengesTests
{
    public class ReversWordsTests
    {
        [Fact]
        public void TestReverseWord_Case1()
        {
            ///feffsfsfs
            // Arrange
            string input = "csharp is programming language";
            string expected = "language programming is csharp";

            // Act
            string actual = ReverseWords.ReverseWord(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReverseWord_Case2()
        {
            // Arrange
            string input = "Reverse the words in this sentence";
            string expected = "sentence this in words the Reverse";

            // Act
            string actual = ReverseWords.ReverseWord(input);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestReverseWord_Case3()
        {
            // Arrange
            string input = "challenges and data structures";
            string expected = "structures data and challenges";

            // Act
            string actual = ReverseWords.ReverseWord(input);

            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
