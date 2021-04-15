using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static uint recursion(uint n)
        {
            if (n < 0)
            {
                return n;
            }
            else
            {
                Console.WriteLine("" + n);
                recursion(n + 1);
                return n;
            }

        }


        static void Main(string[] args)
        {
            recursion( -1 );
            Console.WriteLine("enter a sentense: ");
            string str= Console.ReadLine();

            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; i ++ )
            {
                if (ch[i] != ' ')
                {
                    Console.Write(ch[i]);
                }

                else
                {

                    Console.WriteLine(" ");
                }
            }

            Console.ReadLine();
        }
    }
}
