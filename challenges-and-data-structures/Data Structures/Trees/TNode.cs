using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees
{
    public class TNode
    {
        public int Value { get; set; }

        public TNode Left { get; set; }

        public TNode Right { get; set; }

        public TNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
