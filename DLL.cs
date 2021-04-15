using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLLTest
{
    class DLL
    {
        private Node head, tail;

        public DLL()
        {
            head = tail = null;
        }

        public void addToHead( string name, char gender )
        {
            Node node = new Node( name, gender );
            if( head==null )
            {
                head = tail = node;
            } else
            {
                node.next = head;
                head.prev = node;
                head = node;
            }
        }

        public void addToTail( string name, char gender )
        {
            Node node = new Node(name, gender);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }
        }

        public void deleteFromHead()
        {
            if( head!=null )
            {
                if( head==tail )
                {
                    Console.WriteLine(head.getName() + ", " + head.getGender() + " is removed from the list" );
                    head = tail = null;
                } 
                else
                {
                    Node temp = head;
                    head = head.next;
                    temp.next = null;
                    head.prev = null;
                    Console.WriteLine(temp.getName() + ", " + temp.getGender() + " is removed from the list");
                    temp = null;
                }
            }
            else
            {
                Console.WriteLine("List is already emtpy!");
            }
        }

        public Node search( string name, char gender )
        {
            Node result = null;
            Node temp = head;
            if (head != null)
            {
                while (temp != null)
                {
                    if (temp.getName() == name && temp.getGender() == gender )
                    {
                        Console.WriteLine("Found element : " + temp.getName() + "," + temp.getGender());
                        result = temp;
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

        public void displayHeadToTail()
        {
            Node temp = head;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.getName() + ", " + temp.getGender() );
                    temp = temp.next;
                }
            }
        }
        public void displayTailToHead()
        {
            Node temp = tail;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.getName() + ", " + temp.getGender());
                    temp = temp.prev;
                }
            }
        }


    }
}
