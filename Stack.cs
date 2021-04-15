using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImpl
{
    class Stack
    {
        private Object[] elements;
        private int top;
        private int size;

        public Stack( int s )
        {
            size = s;
            top = -1;
            elements = new Object[ size ];
        }

        public void push( Object o )
        {
            if( top==size-1)
            {
                Console.WriteLine( "Stack is Full" );
            }
            else
            {
                top++;
                elements[top] = o;
            }
        }

        public Object pop()
        {
            if( top==-1 )
            {
                Console.WriteLine( "Stack is Empty" );
                return null;
            } 
            else
            {
                Object o = elements[top];
                top--;
                return o;
            }
        }

        public Object peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return null;
            }
            else
            {
                return elements[top];
            }
        }

    }
}
