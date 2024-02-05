using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Student : Base
    {
        public override string getName()
        {
            return GetStudentName();
        }

        public override void setName(string name)
        {
            throw new NotImplementedException();
        }

        private string GetStudentName()
        {
            //throw new NotImplementedException();
            return "Full Name";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Id.Equals(student.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
//public override string Name => GetStudentName();