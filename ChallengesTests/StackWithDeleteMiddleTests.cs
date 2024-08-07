using challenges_and_data_structures.Data_Structures.Stack___Queue.DeleteMiddleElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void TestDeleteMiddle_OddSizedStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.DeleteMiddle();

            Assert.Equal(4, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestDeleteMiddle_EvenSizedStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.DeleteMiddle();

            Assert.Equal(4, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestDeleteMiddle_EmptyStack()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();

            Assert.Throws<InvalidOperationException>(() => stack.DeleteMiddle());
        }

        [Fact]
        public void TestDeleteMiddle_SingleElement()
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(1);

            stack.DeleteMiddle();

            Assert.True(stack.IsEmpty());
        }
    }
}
