using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOConcepts
{
    public abstract class Parent
    {
        public int method( int a, int b )
        {
            return a * b;
        }

        public abstract void calculateSalary();
    }
}
