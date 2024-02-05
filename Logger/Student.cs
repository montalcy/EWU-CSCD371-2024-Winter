using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Student : Base
    {
        public Student() { }

        //public override string Name => GetStudentName();
        public override string Name { get => throw new NotImplementedException(); init => GetStudentName(); }

        private string GetStudentName()
        {
            //throw new NotImplementedException();
            return "Full Name";
        }
    }
}
