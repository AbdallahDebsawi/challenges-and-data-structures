using challenges_and_data_structures.Data_Structures.Stack___Queue.ReverseStackUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class StackWithReverseTests
    {
        [Fact]
        public void TestReverseStack_MultipleElements()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
        }

        [Fact]
        public void TestReverseStack_SingleElement()
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestReverseStack_EmptyStack()
        {
            StackWithReverse stack = new StackWithReverse();

            stack.ReverseStack();

            Assert.True(stack.IsEmpty());
        }
    }
}
