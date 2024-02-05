using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Book : Base
    {
        public Book() { }
        public Book(string name) { }
        public Book(string name, int id) { }

        public override string Name { get => throw new NotImplementedException(); init => throw new NotImplementedException(); }
    }
}
