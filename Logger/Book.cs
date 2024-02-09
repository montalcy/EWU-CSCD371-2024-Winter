using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book: Base
{
    private string FullName { get; set; }
    private Guid Identity { get; set; }


    public Book(string title)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(title);
        FullName = title;
        Identity = new Guid();
    }

    public Guid Id { get { return Identity; } set{ } }

    public override string Name { get { return FullName; } set { } }

}
// We implemented Name and id Implicitly here as we are feeding the name
//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }