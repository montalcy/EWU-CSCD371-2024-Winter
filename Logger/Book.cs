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
    private string Author;
    private string isbn;
    private Guid identity;


    public Book(string author, string isbn)
    {
        Author = author;
        this.isbn = isbn;
        identity = new Guid();
    }

    public Guid id { get { return identity; } }

    public override string Name { get { return isbn + " " + Author; } set { /*Name = isbn + " " + Author;*/ } }

}
// We implmented Name Implicitly here as we are feeding the name
//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }