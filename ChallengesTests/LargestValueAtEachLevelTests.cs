using challenges_and_data_structures.Data_Structures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class LargestValueAtEachLevelTests
    {
        [Fact]
        public void LargestLevelValue_Test()
        {
            BinaryTree Btree = new BinaryTree(5);
           
            Btree.Root.Left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.Left.Left.Left = new TNode(1);
            Btree.Root.Left.Left.Right = new TNode(4);
            Btree.Root.Right.Left.Right = new TNode(11);

            List<int> largestValues = Btree.LargestLevelValue();

            Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
            Assert.Equal(49, largestValues.Sum());
        }
    }
}
