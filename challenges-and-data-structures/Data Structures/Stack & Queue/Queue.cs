using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Stack___Queue
{
    public class Queue
    {
        private Node front;
        private Node back;

        public Queue()
        {
            front = null;
            back = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (back != null)
            {
                back.Next = newNode;
            }
            back = newNode;
            if (front == null)
            {
                front = back;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            int data = front.Data;
            front = front.Next;
            if (front == null)
            {
                back = null;
            }
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }

        public void PrintQueue()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}
