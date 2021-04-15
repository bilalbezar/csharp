using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTest
{
    class Queue
    {
        private int front;
        private int rear;

        private int[] elements;
        private int size;

        public Queue( int s )
        {
            size = s;
            elements = new int[ size ];
            front = rear = -1;
        }

        public void enQueue( int element)
        {
            if( rear==-1 )
            {
                front = rear = 0;
                elements[rear] = element;
                Console.WriteLine("Element is Inserted!");
            }
            else if (front == 0 && rear == (size - 1))
            {
                Console.WriteLine("Queue is Full!");
            }
            else if ( (rear+1) == front )
            {
                Console.WriteLine("Queue is Full!");
            }
            else
            {
                if( rear>=front && rear!=(size-1) )
                {
                    rear++;
                    elements[rear] = element;
                    Console.WriteLine("Element is Inserted!");
                } else if( rear==(size-1) && front>0 )
                {
                    rear = 0;
                    elements[rear] = element;
                    Console.WriteLine("Element is Inserted!");
                } else
                {
                    rear++;
                    elements[rear] = element;
                    Console.WriteLine("Element is Inserted!");
                }
            }
        }

        public int deQueue()
        {
            int element = -1;
            if(front == -1)
            {
                Console.WriteLine("Queue is Empty!");
            } else
            {
                element = elements[front];
                if( rear==front )
                {
                    front = rear = -1;
                    Console.WriteLine("Queue is now Empty!");
                } else
                {
                    front++;
                }
            }

            return element;
        }

        public int peek()
        {
            int element = -1;
            if( front!=-1)
            {
                element = elements[front];
            }
            return element;
        }

    }
}
