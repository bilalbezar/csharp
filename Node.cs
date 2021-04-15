using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    class Node
    {
        private int data;
        private Node next;

        public Node()
        {
            data = -1;
            next = null;
        }

        public Node( int d )
        {
            data = d;
            next = null;
        }
    }
}
