using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Stack___Queue.DeleteMiddleElement
{
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            Stack<int> tempStack = new Stack<int>();
            int count = 0;
            Node current = top;

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            int middleIndex = count / 2;

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(Pop());
            }
            Pop();

            while (tempStack.Count > 0)
            {
                Push(tempStack.Pop());
            }
        }
    }
}
