using challenges_and_data_structures.Data_Structures.Stack___Queue.MinStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MinStackTests
    {
        [Fact]
        public void TestGetMin_AfterPushOperations()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);

            Assert.Equal(3, minStack.GetMin());
        }

        [Fact]
        public void TestGetMin_AfterPopOperations()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            minStack.Pop();

            Assert.Equal(7, minStack.GetMin());
        }

        [Fact]
        public void TestPushAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(10);
            minStack.Push(20);
            minStack.Push(5);

            Assert.Equal(5, minStack.GetMin());
        }

        [Fact]
        public void TestTopAndPopOperations()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);

            Assert.Equal(12, minStack.Top());
            Assert.Equal(12, minStack.Pop());
            Assert.Equal(7, minStack.Top());
        }

        [Fact]
        public void TestIsEmpty()
        {
            MinStack minStack = new MinStack();
            Assert.True(minStack.IsEmpty());

            minStack.Push(5);
            Assert.False(minStack.IsEmpty());

            minStack.Pop();
            Assert.True(minStack.IsEmpty());
        }
    }
}
