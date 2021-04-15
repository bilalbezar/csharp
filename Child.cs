using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOConcepts
{
    class Child : Parent
    {
        public int method(int a, int b) //method overriding
        {
            return a + b;
        }

        public override void calculateSalary()
        {

        }

    }
}
