using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT
{
    class BTNode
    {
        private int data;
        public BTNode left;
        public BTNode right;

        public BTNode( int d )
        {
            data = d;
            left = right = null;
        }

        public int getData()
        {
            return data;
        }
    }
}
