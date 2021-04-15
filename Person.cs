using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrays
{
    class Person : Object
    {
        private string name;
        private string address;
        private int age;

        public void setName( string n )
        {
            name = n;
        }

        public string getName()
        {
            return name;
        }
    }
}
