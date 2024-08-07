﻿using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static challenges_and_data_structures.Data_Structures.LinkedList.LinkedList;

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

        //Remove Duplicates Tests
        [Fact]
        public void TestNoDuplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.RemoveDuplicates();

            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", GetListString(list));
        }

        [Fact] 
        public void TestRemoveDuplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            list.RemoveDuplicates();

            Assert.Equal("Head -> 5 -> 20 -> 10 -> Null", GetListString(list));
        }

        [Fact]
        public void TestAllDuplicates()
        {
            LinkedList list = new LinkedList();
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);

            list.RemoveDuplicates();

            Assert.Equal("Head -> 7 -> Null", GetListString(list));
        }

   
        //MergeSortedList
        [Fact]
        public void TestMergingWhenOneListIsEmpty()
        {
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();

            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            Assert.Equal("Head -> 1 -> 3 -> 5 -> Null", GetListString(mergedList));
        }

        [Fact]
        public void TestMergingWhenBothListsAreEmpty()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            Assert.Equal("Head -> Null", GetListString(mergedList));
        }

        [Fact]
        public void TestMergingTwoSortedLists()
        {
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", GetListString(mergedList));
        }

        private string GetListString(LinkedList list)
        {
            Node current = list.Head;
            string result = "Head -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "Null";
            return result;
        }
    }
}