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
    public override string Name { get { return BookName; } set { Name = ; } }

    
    public bool Equals(object? obj)
    {
        return obj is Book other &&
               Name == other.Name &&
               Equals(Name, other.Name);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }

    //public override bool Equals(Object? other) =>
    //    EqualityComparer<string>.Default.Equals(Name, other.Name);

    //public override int GetHashCode()
    //{
    //    static int GetHashCode(int integer) =>
    //        EqualityComparer<int>.Default.GetHashCode(integer);

    //    return GetHashCode(Degrees) * -1521134295
    //        + GetHashCode(Minutes) * -1521134295
    //        + GetHashCode(Seconds) * -1521134295
    //        + EqualityComparer<string>.Default.GetHashCode(Name!);
    //}
}

//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }