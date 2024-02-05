using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Employee : Base
    {
        public override string getName()
        {
            return getEmployeeName();
        }

        public override void setName(string name)
        {
            throw new NotImplementedException();
        }

        private string getEmployeeName()
        {
            //throw new NotImplementedException();
            return "Full Name";
        }
        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   Id.Equals(employee.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
//public override string Name => getEmployeeName();