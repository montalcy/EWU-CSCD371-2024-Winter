using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Book : Base
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public override string getName()
        //{
        //    return getBookName();
        //}

        //public override void setName(string name)
        //{
        //    throw new NotImplementedException();
        //}
        public string getBookName()
        {
            return "Book Name";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }