using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public record class FullName
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; } = string.Empty;

    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = null;
    }
    public FullName(string firstName, string lastName, string? middleName)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }
    public override string ToString()
    {
        string fullName = FirstName;
        if (MiddleName != null)
        {
            fullName += " " + MiddleName + " " + LastName;
        }
        else if (LastName != null)
        {
            fullName += LastName;
        }

        return fullName;
    }

}

