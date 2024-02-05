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

        public override string Name { get => throw new NotImplementedException(); init => GetBookName(); }
        //public override string Name => GetBookName();
        //public override string Name { init => GetBookName(); }

        private string GetBookName()
        {
            //throw new NotImplementedException();
            return "Book Name";
        }
       
    }
}
