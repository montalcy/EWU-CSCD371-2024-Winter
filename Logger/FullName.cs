using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public readonly record struct FullName
{
    private string FirstName { get; } 
    private string LastName { get; } 
    private string? MiddleName { get; } 

    public FullName(string firstName, string lastName)
    {
        ArgumentNullException.ThrowIfNullOrEmpty (firstName);
        ArgumentNullException.ThrowIfNullOrEmpty(lastName);
        FirstName = firstName;
        LastName = lastName;
        MiddleName = null;
    }
    public FullName(string firstName, string lastName, string? middleName)
    {
        ArgumentNullException.ThrowIfNullOrEmpty(firstName);
        ArgumentNullException.ThrowIfNullOrEmpty(lastName);
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
    }

    public string GetFullName() =>
       MiddleName == null ? FirstName + " " + MiddleName + " " + LastName : FirstName + " " + LastName;

}
// Decided on it to be struct after being reminded that it would be better as a value type as all its doing is dealing with a few variables
// chose for it to be immutable as having it be mutable could open it up for exploits, used readonly modifier