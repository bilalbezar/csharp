using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    class Vertex
    {
        private int data;

        public Vertex down;
        public Edge next;
    }
}