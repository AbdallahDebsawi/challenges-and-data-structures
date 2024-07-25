using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using challenges_and_data_structures.Data_Structures.Stack___Queue;

namespace ChallengesTests
{
    public class StackAndQueueTests
    {
        [Fact]
        public void TestPush()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void TestPop()
        {
            Stack stack = new Stack();
            stack.Push(10);
            int result = stack.Pop();
            Assert.Equal(10, result);
        }

        [Fact]
        public void TestIsEmpty()
        {
            Stack stack = new Stack();
            Assert.True(stack.IsEmpty());
        }
    }

    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue queue = new Queue();
            queue.Enqueue(10);
            int result = queue.Dequeue();
            Assert.Equal(10, result);
        }

        [Fact]
        public void TestIsEmpty()
        {
            Queue queue = new Queue();
            Assert.True(queue.IsEmpty());
        }
    }
}
