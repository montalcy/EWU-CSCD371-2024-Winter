using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public class PersonName
{
    //public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    private readonly string _firstName;
    private readonly string _lastName;
    private readonly string? _middleName;

    public PersonName(string firstName, string lastName, string? middleName)
    {
        _firstName = firstName;
        _lastName = lastName;
        _middleName = middleName;
    }
    public PersonName(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string makeFullName()
    {
        ArgumentNullException.ThrowIfNullOrEmpty(_firstName);
        ArgumentNullException.ThrowIfNullOrEmpty(_lastName);
        string full;
        if (_middleName != null)
        {
            FullName fullName = new(_firstName, _lastName, _middleName);
            full = fullName.ToString();
        }
        else
        {
            FullName fullName = new(_firstName, _lastName);
            full = fullName.ToString();
        }

        return full;
    }
    //public string FirstName { get => _firstName; set => throw new NotImplementedException(); }
    //public string LastName { get => _lastName; set => throw new NotImplementedException(); }

}
