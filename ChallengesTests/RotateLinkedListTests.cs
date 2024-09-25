using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class RotateLinkedListTests
    {
        [Fact]
        public void RotateByZero_ShouldRemainUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null", list.PrintList());
        }

        [Fact]
        public void RotateByGreaterThanLength_ShouldWrapCorrectly()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            // The length of the list is 6, so rotating by k = 7 should be the same as rotating by k = 1
            // After rotation, the list should become: 2 -> 3 -> 4 -> 5 -> 6 -> 1 -> Null

            // Act
            list.RotateLeft(7);

            // Assert
            Assert.Equal("2 -> 3 -> 4 -> 5 -> 6 -> 1 -> Null", list.PrintList());
        }

        [Fact]
        public void RotateByLength_ShouldRemainUnchanged()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            // Act
            list.RotateLeft(6);  // Rotating by the list length should give the same list

            // Assert
            Assert.Equal("1 -> 2 -> 3 -> 4 -> 5 -> 6 -> Null", list.PrintList());
        }

        [Fact]
        public void RotateBySomeValue_ShouldRotateCorrectly()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            // Act
            list.RotateLeft(2);

            // Assert
            Assert.Equal("3 -> 4 -> 5 -> 6 -> 1 -> 2 -> Null", list.PrintList());
        }
    }
}
