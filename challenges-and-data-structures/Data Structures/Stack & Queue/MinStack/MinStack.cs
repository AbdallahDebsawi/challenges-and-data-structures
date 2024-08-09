using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Stack___Queue.MinStack
{
    public class MinStack
    {
        private Stack<int> mainStack;
        private Stack<int> minStack;

        public MinStack()
        {
            mainStack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int data)
        {
            mainStack.Push(data);
            if (minStack.Count == 0 || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            if (mainStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            int poppedValue = mainStack.Pop();
            if (poppedValue == minStack.Peek())
            {
                minStack.Pop();
            }
            return poppedValue;
        }

        public int Top()
        {
            if (mainStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return mainStack.Peek();
        }

        public bool IsEmpty()
        {
            return mainStack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.Write("Top -> ");
            foreach (int item in mainStack)
            {
                Console.Write(item + " -> ");
            }
            Console.WriteLine("null");
        }
    }
}
