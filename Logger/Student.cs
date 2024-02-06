using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Student : Base
{
    private string _firstName;
    private string _lastName;
    private string? _middleName;
    private FullName FullName;
    public Student(string firstName, string lastName, FullName fullname, string? middleName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
        FullName = fullname;
    }


    public override string Name { get { return FullName.GetFullName(); } set { Name = FullName.GetFullName(); } }
}
