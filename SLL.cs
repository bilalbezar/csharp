using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTest
{
    class SLL
    {
        private Node head;
        private Node tail;

        public SLL()
        {
            head = tail = null;
        }

        public void addToHead( int data )
        {
            Node n = new Node( data );
            if( head==null )
            {
                head = tail = n;
            } else
            {
                n.next = head;
                head = n;
            }
        }

        public void addToTail( int data )
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = tail = n;
            } else
            {
                tail.next = n;
                tail = n;
            }
        }

        public void removeFromHead()
        {
            if( head==null )
            {
                Console.WriteLine( "SLL is Empty!" );
            } else
            {
                Console.WriteLine( head.getData() + " is Removed from Head!" );
                if( head==tail )
                {
                    head = tail = null;
                } else
                {
                    head = head.next;
                }
            }
        }

        public void removeFromTail()
        {
            if( head==null )
            {
                Console.WriteLine("SLL is Empty!");
            } else
            {
                Console.WriteLine(tail.getData() + " is Removed from Tail!");
                if (head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    Node temp = head;
                    while( temp.next != tail )
                    {
                        temp = temp.next;
                    }
                    tail = temp;
                    tail.next = null;
                }
            }
        }

        public void display()
        {
            Node temp = head;
            if( head!=null )
            {
                while( temp!=null )
                {
                    Console.WriteLine(temp.getData());
                    temp = temp.next;
                }
            }
        }

        public void delete( int data )
        {

        }

        public int search( int data )
        {
            int result = -1;
            Node temp = head;
            if (head != null)
            {
                while (temp != null)
                {
                    if (temp.getData() == data)
                    {
                        Console.WriteLine( "Found element : " + temp.getData() );
                        result = temp.getData();
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
            return result;
        }

        public int count()
        {
            int count = 0;
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }

        public void reverseElements()
        {
            Node prev = null, curr = head, next = null;

            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

        public void removeDuplicates()
        {
            Node curr = head, temp = null;

            if (head == null)
                return;


            while (curr.next != null)
            {
                if (curr.getData() == curr.next.getData())
                {
                    Console.WriteLine("Found element : " + curr.getData());
                    temp = curr.next.next;
                    curr.next.next = null;
                    curr.next = temp;
                }
                else
                {
                    curr = curr.next;
                }
            }
        }


    }
}
