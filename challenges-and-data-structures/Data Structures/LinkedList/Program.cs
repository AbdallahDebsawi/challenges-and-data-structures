using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get;  set; }

        public LinkedList()
        {
            Head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Includes(int data)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (Head == null)
            {
                throw new InvalidOperationException("The list is empty.");
            }

            if (Head.Data == data)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;
            while (current.Next != null && current.Next.Data != data)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                throw new InvalidOperationException("The specified node is not in the list.");
            }

            current.Next = current.Next.Next;
        }

        public string PrintList()
        {
            if (Head == null)
            {
                return "Null";
            }

            Node current = Head;
            StringBuilder result = new StringBuilder();
            while (current != null)
            {
                result.Append(current.Data).Append(" -> ");
                current = current.Next;
            }
            result.Append("Null");
            return result.ToString();
        }

        public void RemoveDuplicates()
        {
            Node current = Head;
            while (current != null)
            {
                Node runner = current;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == current.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                current = current.Next;
            }
        }

        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            LinkedList mergedList = new LinkedList();
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }

            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }
        public void RotateLeft(int k)
        {
            if (Head == null || k == 0) return; // Edge case: empty list or no rotation needed

            // Step 1: Calculate the length of the linked list
            Node current = Head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            // Step 2: Normalize k in case it exceeds the length of the list
            k = k % length;
            if (k == 0) return; // Edge case: k is a multiple of the list length (no change)

            // Step 3: Connect the tail to the head, forming a circular linked list
            current.Next = Head;

            // Step 4: Find the new head (move `k` steps forward from the original head)
            Node newTail = Head;
            for (int i = 1; i < k; i++)
            {
                newTail = newTail.Next;
            }

            // Step 5: The new head is the node after newTail
            Head = newTail.Next;

            // Step 6: Break the circular link by setting newTail.Next to null
            newTail.Next = null;
        }

        // Display method for printing the list
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}