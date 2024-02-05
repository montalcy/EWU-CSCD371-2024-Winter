using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Student : Base
    {
        public override string Name { get => throw new NotImplementedException(); init => GetStudentName(); }
        public Student() { }
        public Student(string name)
        {
            Name = name;
        }

        private string GetStudentName()
        {
            //throw new NotImplementedException();
            return "Full Name";
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   Id.Equals(student.Id) &&
                   Name == student.Name;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
//public override string Name => GetStudentName();