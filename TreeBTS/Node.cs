using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeBTS
{
    class Node
    {
        private int data;
        private Node left, right;

        public Node(int data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right; 
        }

        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null; 
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

    }
}
