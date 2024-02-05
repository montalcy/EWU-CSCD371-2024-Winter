using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class PersonName : Base
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private readonly string _firstName;
        private readonly string _lastName;
        private readonly string? _middleName;

        public PersonName(string name, string firstName, string lastName, string? middleName)
        {
            Name = name;
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
            
            FullName fullName = new();
            return "";
        }
        //public string FirstName { get => _firstName; set => throw new NotImplementedException(); }
        //public string LastName { get => _lastName; set => throw new NotImplementedException(); }
        
    }
}
