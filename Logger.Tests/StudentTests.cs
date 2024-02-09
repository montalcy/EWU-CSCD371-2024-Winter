using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Logger.Tests
{
    public class StudentTests
    {
        [Fact]
        public void StudentConstructor_CheckingEquality_Equal()
        {

            //should return true since they are the same type of records
            Base student1 = new Student("First", "Last", null);
            Base student2 = new Student("First2", "Last2", null);
            Assert.Equal(student1.GetType(), student2.GetType());

        }
        [Fact]
        public void StudentConstructor_CheckingEquality_NotEqual()
        {

            //should return true since they are the same type of records
            Base student1 = new Student("First", "Last", null);
            Base student2 = new Employee("First2", "Last2", null);
            Assert.NotEqual(student1.GetType(), student2.GetType());

        }

    }
}
