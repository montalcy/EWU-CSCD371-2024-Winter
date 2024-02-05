using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Book : Base
    {
        public override string Name { get => throw new NotImplementedException(); init => GetBookName(); }
        public Book() { }
        public Book(string name)
        {
            Name = name;
        }

        

        private string GetBookName()
        {
            //throw new NotImplementedException();
            return "Book Name";
        }
        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   Id.Equals(book.Id) &&
                   Name == book.Name;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }