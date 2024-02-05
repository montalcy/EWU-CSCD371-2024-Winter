using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;
    public record class Employee : Base
    {
        public override string Name { get => GetEmployeeName(); set => SetEmployeeName(); }
        private string _firstName;
        private string _lastName;
        private string? _middleName;
        private string? full;
        public Employee(string firstName, string lastName, string middleName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(_firstName);
            ArgumentNullException.ThrowIfNullOrEmpty(_lastName);
            ArgumentNullException.ThrowIfNullOrEmpty(_middleName);
            _firstName = firstName;
            _lastName = lastName;
            _middleName = middleName;
        }
        public Employee(string firstName, string lastName)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(_firstName);
            ArgumentNullException.ThrowIfNullOrEmpty(_lastName);
            _firstName = firstName;
            _lastName = lastName;
            _middleName = null;
        }
        //public override string getName()
        //{
        //    return getEmployeeName();
        //}

        //public override void setName(string name)
        //{
        //    throw new NotImplementedException();
        //}

        private string GetEmployeeName()
        {
            return full!;
        }
        private void SetEmployeeName()
        {
            

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

//public override string Name => getEmployeeName();