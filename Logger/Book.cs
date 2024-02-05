using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

    public record class Book : Base
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string _firstName;
        private string _lastName;
        private string? _middleName;
        private string? full = "";

        public Book(string firstName, string lastName, string middleName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(_firstName);
            ArgumentNullException.ThrowIfNullOrEmpty(_lastName);
            ArgumentNullException.ThrowIfNullOrEmpty(_middleName);
            _firstName = firstName;
            _lastName = lastName;
            _middleName = middleName;
        }
        public Book(string firstName, string lastName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(_firstName);
            ArgumentNullException.ThrowIfNullOrEmpty(_lastName);
            _firstName = firstName;
            _lastName = lastName;
        }
        //public override string getName()
        //{
        //    return getBookName();
        //}

        //public override void setName(string name)
        //{
        //    throw new NotImplementedException();
        //}
        public string getBookName()
        {
            return full!;
        }
        public void SetBookName()
        {
            string full;

            if (_middleName != null)
            {
                PersonName personName = new(_firstName, _lastName, _middleName);
                full = personName.makeFullName();
            }
            else
            {
                PersonName personName = new(_firstName, _lastName);
                full = personName.makeFullName();
            }
        }
    }

//public override string Name => GetBookName();
//public override string Name { init => GetBookName(); }