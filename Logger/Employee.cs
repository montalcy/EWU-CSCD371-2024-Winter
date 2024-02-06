using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public record class Employee : Base
{
    private string _firstName;
    private string _lastName;
    private string? _middleName;
    private FullName FullName;

    public Employee(string firstName, string lastName, string? middleName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
        FullName = new FullName(_firstName, _lastName);
    }

    public override string Name { get { return FullName.GetFullName(); } set { Name = FullName.GetFullName(); } }
}

//public override string Name => getEmployeeName();