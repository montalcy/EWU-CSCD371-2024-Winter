using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
public record class Employee : Person
{
    public Employee(string firstName, string lastName, string? middleName) : base(firstName, lastName, middleName)
    {
    }
}
