using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class LinkedListTests
    {
        [Fact]
        public void RemoveNodeFromEndOfList()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Remove(20);

            Node current = list.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Assert.Null(current.Next);
        }

        [Fact]
        public void PrintListCorrectly()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();
                Assert.Equal("Head -> 5 -> 10 -> 20 -> Null", result);
            }
        }

        [Fact]
        public void IncludesNodeInList()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            Assert.True(list.Includes(10));
            Assert.False(list.Includes(30));
        }

        [Fact]
        public void RemoveNonExistentNodeThrowsException()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            Assert.Throws<InvalidOperationException>(() => list.Remove(30));
        }
    }
}