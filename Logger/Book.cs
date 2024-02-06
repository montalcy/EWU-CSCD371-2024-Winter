using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book : Base
{
    private string BookName;
    public Book(string Name)
    {
        BookName = Name;
    }
    public override string Name { get { return BookName; } set { Name = BookName; } }

}

//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }