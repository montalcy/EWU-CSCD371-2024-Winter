using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Book : Base
    {
        public override string getName()
        {
            return getBookName();
        }

        public override void setName(string name)
        {
            throw new NotImplementedException();
        }
        public string getBookName()
        {
            return "Book Name";
        }

        public override bool Equals(object? obj)
        {
            return obj is Book book &&
                   Id.Equals(book.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }