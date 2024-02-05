using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Employee : Base
    {
        public Employee() { }

        //public override string Name => getEmployeeName();
        public override string Name { get => throw new NotImplementedException(); init => getEmployeeName(); }

        private string getEmployeeName()
        {
            //throw new NotImplementedException();
            return "Full Name";
        }
        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id.Equals(employee.Id) &&
                   Name == employee.Name &&
                   Name == employee.Name;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
