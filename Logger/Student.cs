﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Student : Base
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

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
//public override string Name => GetStudentName();