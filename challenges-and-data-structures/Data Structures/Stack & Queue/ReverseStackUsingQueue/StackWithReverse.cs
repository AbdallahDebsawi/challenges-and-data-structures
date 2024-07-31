using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Stack___Queue.ReverseStackUsingQueue
{
    public class StackWithReverse : Stack
    {
        public void ReverseStack()
        {
            Queue<int> queue = new Queue<int>();

            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            while (queue.Count > 0)
            {
                Push(queue.Dequeue());
            }
        }
    }
}
