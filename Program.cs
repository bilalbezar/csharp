using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = -1;
            Console.Write( "Provide size of the Stack: " );
            size = Convert.ToInt32( Console.ReadLine() );
            Stack stack = new Stack( size );
            int option = -1;

            do
            {
                Console.WriteLine("1. Insert an element");
                Console.WriteLine("2. Remove an element");
                Console.WriteLine("3. Peek the Stack");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch( option )
                {
                    case 1:
                        Console.Write( "Enter String you Want to Insert in the Stack" );
                        string input = Console.ReadLine();
                        stack.push(input);
                        break;
                    case 2:
                        string element = ( string )stack.pop();
                        Console.WriteLine( "Following String is Removed\n" + element );
                        break;
                    case 3:
                        Console.WriteLine("Following String is the Top Most Element in the Stack\n" + stack.peek());
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }

            } while ( true );
        }
    }
}
