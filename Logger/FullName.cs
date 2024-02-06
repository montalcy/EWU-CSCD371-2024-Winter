using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public record class FullName
{
    private string FirstName { get; set; }
    private string LastName { get; set; } 
    private string? MiddleName { get; set; } 

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

    public string GetFullName() =>
       MiddleName == null ? FirstName + " " + MiddleName + " " + LastName : FirstName + " " + LastName;

}

