using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class FullName
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; } = string.Empty;

        public FullName(string firstName, string lastName) 
        { 
            FirstName = firstName;
            LastName = lastName;
        }
        public FullName(string firstName, string lastName, string? middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        
    }
}
