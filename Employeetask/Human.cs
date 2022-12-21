using System;
using System.Collections.Generic;
using System.Text;

namespace Employeetask
{
    internal class Human
    {
        public Human(string fullname, byte age)
        {
            Fullname = fullname;
            Age = age;
        }

        public string Fullname;
        public byte Age;
    }
}
